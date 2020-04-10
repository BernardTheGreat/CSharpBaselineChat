using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace ChatApplicationBaseline
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormChatbox());
        }

        public static MySqlConnection mysql_conn = new MySqlConnection("Server=localhost;Database=chat;Uid=root;Pwd=d@tabas3;");
        
        public static ushort current_user_id = 1;


    }
}
