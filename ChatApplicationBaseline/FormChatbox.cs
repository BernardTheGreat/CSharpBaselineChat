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
    public partial class FormChatbox : Form
    {
        public FormChatbox()
        {
            InitializeComponent();
        }

        private static List<Message> msgs = new List<Message>();
        public static UInt32 last_output_msg_id = 0;

        private void FormChatbox_Load(object sender, EventArgs e)
        {
            //StartReceivingMessages();
        }

        private void SendMessage(string msg)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand("Insert into messages(user_id,content) values(?,?)", Program.mysql_conn);
                MySqlParameter param1 = new MySqlParameter();
                MySqlParameter param2 = new MySqlParameter();
                param1.Value = Program.current_user_id;
                param2.Value = msg;
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sent");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ReceiveMessage()
        {
            //MessageBox.Show("receive");
            
            MySqlCommand mysql_cmd = new MySqlCommand("select a.id, a.content, b.fullname from messages a inner join users b on a.user_id = b.id where a.id > ? and a.user_id <> ?", Program.mysql_conn);
            MySqlParameter param1 = new MySqlParameter();

            if (msgs.Count == 0)
            {
                param1.Value = 0;
            }
            else
            {
                param1.Value = last_output_msg_id;
            }



            MySqlParameter param2 = new MySqlParameter();
            param2.Value = Program.current_user_id;

            mysql_cmd.Parameters.Add(param1);
            mysql_cmd.Parameters.Add(param2);
            //MySqlParameter param1 = new MySqlParameter();
            //param1.Value = sender_id;


            using (MySqlDataReader data_reader = mysql_cmd.ExecuteReader())
            {

                while (data_reader.Read())
                {
                    Message msg = new Message();
                    msg.Id = data_reader.GetUInt32(0);
                    msg.Content = data_reader.GetString(1);
                    msg.user_name = data_reader.GetString(2);
                    //msg.DateTimeSent = data_reader.GetDateTime(2);
                    msgs.Add(msg);

                }
            }

        
            
        }

        private void StartReceivingMessages()
        {

            

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            SendMessage(messageTxtbox.Text);

            chatBoxRichTxtBox.Text = chatBoxRichTxtBox.Text + "Me: " + messageTxtbox.Text + Environment.NewLine;

            messageTxtbox.Text = "";
        }

        private void ShowMessages()
        {
           
            foreach (Message msg in msgs) // Loop through List with foreach
            {
                
                if (msg.Id > last_output_msg_id)
                {
                    chatBoxRichTxtBox.Text = chatBoxRichTxtBox.Text + msg.user_name + ": " + msg.Content + Environment.NewLine;
                }


            }

            last_output_msg_id = msgs[msgs.Count - 1].Id;
        }

        private void FormChatbox_Shown(object sender, EventArgs e)
        {
            Program.mysql_conn.Open();
            backgroundWorker1.RunWorkerAsync();
        }

        private void FormChatbox_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.mysql_conn.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            while (true)
            {
                ReceiveMessage();
                backgroundWorker1.ReportProgress(0);
                Thread.Sleep(1000);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ShowMessages();
        }



   } 

    class Message
    {

        public UInt32 Id { get; set; }
        public String Content { get; set; }

        public String user_name { get; set; }
        public ushort UserId { get; set; }
        //public DateTime DateTimeSent;

    }
}
