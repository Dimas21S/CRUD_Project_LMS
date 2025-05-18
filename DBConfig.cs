using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Project_LMS
{
    public static class DBConfig
    {
        public static string dbServer = "localhost";
        public static string dbUser = "root";
        public static string dbName = "winform_db";
        public static string dbPass = "";
        public static string dbPort = "";

        public static string ConsStr = $"server={dbServer};user={dbUser};database={dbName};password={dbPass};port={dbPort}";
    }
}
