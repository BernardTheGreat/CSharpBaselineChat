using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using MySql.Data.MySqlClient;

namespace ChatApplicationBaseline
{
    public partial class FormLogin : Form
    {
        private static List<User> users = new List<User>();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(usernameTxtbox.Text) && string.IsNullOrWhiteSpace(passwordTxtbox.Text)) {
                MessageBox.Show("Please enter credentials");
            }
            else
            {
                usernameTxtbox.Enabled = false;
                passwordTxtbox.Enabled = false;
                loginBtn.Enabled = false;
                loginQueryBckgrndWrkr.RunWorkerAsync();
            }
        }

        private void loginQueryBckgrndWrkr_DoWork(object sender, DoWorkEventArgs e)
        {

            Program.mysql_conn.Open();

            MySqlCommand mysql_cmd = new MySqlCommand("select id,username,password from users where username = ? and password = ?", Program.mysql_conn);

            MySqlParameter userParam = new MySqlParameter();
            MySqlParameter passwordParam = new MySqlParameter();
            userParam.Value = usernameTxtbox.Text;
            passwordParam.Value = passwordTxtbox.Text;

            mysql_cmd.Parameters.Add(userParam);
            mysql_cmd.Parameters.Add(passwordParam);


            using (MySqlDataReader user_data_reader = mysql_cmd.ExecuteReader())
            {
                if (user_data_reader.Read())
                {
                    if (user_data_reader.HasRows)
                    {


                        User user = new User();
                        user.Id = user_data_reader.GetUInt16(0);
                        user.Username = user_data_reader.GetString(1);
                        user.Password = user_data_reader.GetString(2);
                        Program.current_user = user;


                        labelcheckUser.ForeColor = Color.Green;
                    }
                    else
                    {

                        MessageBox.Show("Invalid Credentials");


                    }
                }
            }

            Program.mysql_conn.Close();
        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
           
        }


        private void loginQueryBckgrndWrkr_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Program.current_user != null)
            {
                MessageBox.Show(Program.current_user.Id.ToString());
                this.Hide();
                FormChatbox formChatbox = new FormChatbox();
                formChatbox.Show();
            }
            else
            {
                usernameTxtbox.Enabled = true;
                passwordTxtbox.Enabled = true;
                loginBtn.Enabled = true;
            }

        }
    }
}
