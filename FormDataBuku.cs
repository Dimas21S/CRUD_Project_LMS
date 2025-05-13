using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_Project_LMS
{
    public partial class FormDataBuku: Form
    {
        private int selectedId = -1;
        private string judul;
        private string penulis;
        private string penerbit;
        private string tahun_terbit;

        public FormDataBuku()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConsStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM buku";
                    MySqlDataAdapter adapted = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapted.Fill(dt);
                    dgvBuku.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error load data: " + ex.Message);
                }
            }

            dgvBuku.Columns["id"].HeaderText = "ID";
            dgvBuku.Columns["id"].Visible = false;

            dgvBuku.Columns["judul"].HeaderText = "Judul";
            dgvBuku.Columns["penulis"].HeaderText = "Penulis";
            dgvBuku.Columns["penerbit"].HeaderText = "Penerbit";
            dgvBuku.Columns["tahun_terbit"].HeaderText = "Tahun Terbit";

        }

        private void ClearForm()
        {
            txtJudul.Clear();
            txtPenulis.Clear();
            txtPenerbit.Clear();
            txtTahunTerbit.Clear();
            selectedId = -1;
            btnSimpan.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConsStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO buku(judul, penulis, penerbit, tahun_terbit)" +
                        "VALUES(@judul, @penulis, @penerbit, @tahun_terbit)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@judul", txtJudul.Text);
                    cmd.Parameters.AddWithValue("@penulis", txtPenulis.Text);
                    cmd.Parameters.AddWithValue("@penerbit", txtPenerbit.Text);
                    cmd.Parameters.AddWithValue("@tahun_terbit", txtTahunTerbit.Text);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Data buku berhasil disimpan !!!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan data: " + ex.Message);
                }
            }

        }

        private void dgvBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object valueSelectedId = dgvBuku.Rows[e.RowIndex].Cells["id"].Value;
                selectedId = (valueSelectedId != null && valueSelectedId != DBNull.Value)
                    ? Convert.ToInt32(valueSelectedId) 
                    : -1;

                txtJudul.Text = dgvBuku.Rows[e.RowIndex].Cells["judul"].Value?.ToString() ?? "";
                txtPenulis.Text = dgvBuku.Rows[e.RowIndex].Cells["penulis"].Value?.ToString() ?? "";
                txtPenerbit.Text = dgvBuku.Rows[e.RowIndex].Cells["penerbit"].Value?.ToString() ?? "";
                txtTahunTerbit.Text = dgvBuku.Rows[e.RowIndex].Cells["tahun_terbit"].Value?.ToString() ?? "";
                btnSimpan.Enabled = false;

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConsStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE buku SET judul=@judul, penulis=@penulis, penerbit=@penerbit," +
                        "tahun_terbit=@tahun_terbit WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.Parameters.AddWithValue("@judul", txtJudul.Text);
                    cmd.Parameters.AddWithValue("@penulis", txtPenulis.Text);
                    cmd.Parameters.AddWithValue("@penerbit", txtPenerbit.Text);
                    cmd.Parameters.AddWithValue("@tahun_terbit", txtTahunTerbit.Text);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Data buku berhasil diperbarui");
                } 
                catch(Exception ex)
                {
                    MessageBox.Show("Gagal memperbarui: " + ex.Message);
                }
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            DialogResult result = MessageBox.Show("Yakin ingin menghapus data buku ini ?", 
                "Konfrimasi", 
                MessageBoxButtons.YesNo
                );

            if (result != DialogResult.Yes) return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConsStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM buku WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Data buku berhasil dihapus");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data: " + ex.Message);
                }
            }

        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtJudul.Text))
            {
                MessageBox.Show("Judul wajib diisi", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJudul.Focus();
                return false;
            }
            else if (txtJudul.Text.Length > 10)
            {
                MessageBox.Show("Judul tidak boleh lebih dari 10 karakter", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJudul.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPenulis.Text))
            {
                MessageBox.Show("Penulis wajib diisi", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPenulis.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPenerbit.Text))
            {
                MessageBox.Show("Penerbit wajib diisi", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPenerbit.Focus();
                return false;
            }

            if (!int.TryParse(txtTahunTerbit.Text, out int tahun) || txtTahunTerbit.Text.Length != 4 || tahun > DateTime.Now.Year)
            {
                MessageBox.Show("Tahun Terbit wajib diisi", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTahunTerbit.Focus();
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
