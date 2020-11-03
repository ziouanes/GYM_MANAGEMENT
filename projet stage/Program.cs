using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projet_stage
{
    static class Program
    {
        // loginform ref
        public static login_form login;

        public static formaccuille accuille;

        // Attributs de SQL Server
        public static SqlConnection Connection = new SqlConnection(@"Data Source = AANDROID-123122\SQLEXPRESS; Initial Catalog = databaseGym; Integrated Security = True");
        public static SqlCommand Command;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(login = new formaccuille());
            Application.Run(new formaccuille());
        }

        // Méthodes
        public static bool IsExist(string identifiant, string nomTable, string champ)
        {
            if (champ != "NumCmd")
                identifiant = "'" + identifiant + "'";
            Connection.Open();
            Command = new SqlCommand("SELECT * FROM " + nomTable + " WHERE " + champ + "=" + identifiant + "", Connection);
            SqlDataReader data = Command.ExecuteReader();
            bool result = data.HasRows;
            data.Close();
            Connection.Close();
            return result;
        }
    }
}
