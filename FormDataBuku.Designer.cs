namespace CRUD_Project_LMS
{
    partial class FormDataBuku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.txtTahunTerbit = new System.Windows.Forms.TextBox();
            this.txtPenerbit = new System.Windows.Forms.TextBox();
            this.txtPenulis = new System.Windows.Forms.TextBox();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.labelPenulis = new System.Windows.Forms.Label();
            this.labelTahunTerbit = new System.Windows.Forms.Label();
            this.labelPenerbit = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.groupBoxAksi = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dgvBuku = new System.Windows.Forms.DataGridView();
            this.groupBoxForm.SuspendLayout();
            this.groupBoxAksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.txtTahunTerbit);
            this.groupBoxForm.Controls.Add(this.txtPenerbit);
            this.groupBoxForm.Controls.Add(this.txtPenulis);
            this.groupBoxForm.Controls.Add(this.txtJudul);
            this.groupBoxForm.Controls.Add(this.labelPenulis);
            this.groupBoxForm.Controls.Add(this.labelTahunTerbit);
            this.groupBoxForm.Controls.Add(this.labelPenerbit);
            this.groupBoxForm.Controls.Add(this.labelJudul);
            this.groupBoxForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxForm.Location = new System.Drawing.Point(53, 34);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(564, 235);
            this.groupBoxForm.TabIndex = 0;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Form";
            // 
            // txtTahunTerbit
            // 
            this.txtTahunTerbit.Location = new System.Drawing.Point(201, 180);
            this.txtTahunTerbit.Name = "txtTahunTerbit";
            this.txtTahunTerbit.Size = new System.Drawing.Size(321, 22);
            this.txtTahunTerbit.TabIndex = 7;
            // 
            // txtPenerbit
            // 
            this.txtPenerbit.Location = new System.Drawing.Point(201, 130);
            this.txtPenerbit.Name = "txtPenerbit";
            this.txtPenerbit.Size = new System.Drawing.Size(321, 22);
            this.txtPenerbit.TabIndex = 6;
            // 
            // txtPenulis
            // 
            this.txtPenulis.Location = new System.Drawing.Point(201, 80);
            this.txtPenulis.Name = "txtPenulis";
            this.txtPenulis.Size = new System.Drawing.Size(321, 22);
            this.txtPenulis.TabIndex = 5;
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(201, 34);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(321, 22);
            this.txtJudul.TabIndex = 4;
            // 
            // labelPenulis
            // 
            this.labelPenulis.AutoSize = true;
            this.labelPenulis.Location = new System.Drawing.Point(21, 86);
            this.labelPenulis.Name = "labelPenulis";
            this.labelPenulis.Size = new System.Drawing.Size(51, 16);
            this.labelPenulis.TabIndex = 3;
            this.labelPenulis.Text = "Penulis";
            // 
            // labelTahunTerbit
            // 
            this.labelTahunTerbit.AutoSize = true;
            this.labelTahunTerbit.Location = new System.Drawing.Point(21, 186);
            this.labelTahunTerbit.Name = "labelTahunTerbit";
            this.labelTahunTerbit.Size = new System.Drawing.Size(83, 16);
            this.labelTahunTerbit.TabIndex = 2;
            this.labelTahunTerbit.Text = "Tahun Terbit";
            // 
            // labelPenerbit
            // 
            this.labelPenerbit.AutoSize = true;
            this.labelPenerbit.Location = new System.Drawing.Point(21, 136);
            this.labelPenerbit.Name = "labelPenerbit";
            this.labelPenerbit.Size = new System.Drawing.Size(57, 16);
            this.labelPenerbit.TabIndex = 1;
            this.labelPenerbit.Text = "Penerbit";
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Location = new System.Drawing.Point(21, 41);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(39, 16);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Judul";
            // 
            // groupBoxAksi
            // 
            this.groupBoxAksi.Controls.Add(this.btnClear);
            this.groupBoxAksi.Controls.Add(this.btnReload);
            this.groupBoxAksi.Controls.Add(this.btnEdit);
            this.groupBoxAksi.Controls.Add(this.btnHapus);
            this.groupBoxAksi.Controls.Add(this.btnSimpan);
            this.groupBoxAksi.Location = new System.Drawing.Point(53, 298);
            this.groupBoxAksi.Name = "groupBoxAksi";
            this.groupBoxAksi.Size = new System.Drawing.Size(564, 249);
            this.groupBoxAksi.TabIndex = 1;
            this.groupBoxAksi.TabStop = false;
            this.groupBoxAksi.Text = "Aksi";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(24, 169);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(512, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(336, 100);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(200, 39);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(24, 100);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 39);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(336, 33);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(200, 39);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(24, 33);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(200, 39);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // dgvBuku
            // 
            this.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuku.Location = new System.Drawing.Point(654, 34);
            this.dgvBuku.Name = "dgvBuku";
            this.dgvBuku.RowHeadersWidth = 51;
            this.dgvBuku.RowTemplate.Height = 24;
            this.dgvBuku.Size = new System.Drawing.Size(726, 513);
            this.dgvBuku.TabIndex = 2;
            this.dgvBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuku_CellClick);
            // 
            // FormDataBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1405, 559);
            this.Controls.Add(this.dgvBuku);
            this.Controls.Add(this.groupBoxAksi);
            this.Controls.Add(this.groupBoxForm);
            this.Name = "FormDataBuku";
            this.Text = "Form1";
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.groupBoxAksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelPenulis;
        private System.Windows.Forms.Label labelTahunTerbit;
        private System.Windows.Forms.Label labelPenerbit;
        private System.Windows.Forms.TextBox txtTahunTerbit;
        private System.Windows.Forms.TextBox txtPenerbit;
        private System.Windows.Forms.TextBox txtPenulis;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.GroupBox groupBoxAksi;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvBuku;
    }
}

