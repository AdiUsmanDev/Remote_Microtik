using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tik4net;
using tik4net.Objects;
using tik4net.Objects.Interface;
using Lextm.SharpSnmpLib;
using logoutmain;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Dapper;

namespace Remote_Microtik
{
    public partial class Form3 : Form
    {
        public string host;
        public string username;
        public string password;

        private ITikConnection connection;
        public Form3()
        {
            InitializeComponent();

            query_data();
             // define.ExecuteMikroTikCommands();
        }


        private void query_data()
        {

            string connectionString = "server=localhost;userid=root;password=root;database=remote_microtik";

            using (MySqlConnection connectionn = new MySqlConnection(connectionString))
            {
                try
                {
                    connectionn.Open();

                    string query = "SELECT * FROM auth_sesion";

                    var selectedData = connectionn.Query(query);


                    foreach (var row in selectedData)
                    {

                        host = row.ip;
                        username = row.username;
                        password = row.pass;



                    }


                    connection.Close();

                    if (selectedData.Any())
                    {
                        this.Hide();
                        Form1 frm1 = new Form1();
                        frm1.ShowDialog();
                    }

                }
                catch
                {

                }

            }
        }

        private void aa(object sender, EventArgs e)
        {
         

            using (connection = ConnectionFactory.CreateConnection(TikConnectionType.Api))
            {
                connection.Open(host, username, password);

                List<Log>logs = connection.LoadAll<Log>().ToList();

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Add("Time", "Time");
                dataGridView1.Columns.Add("Topik", "Topik");
                dataGridView1.Columns.Add("Pesan", "Pesan");
                

                dataGridView1.Columns["Time"].DataPropertyName = "Time";
                dataGridView1.Columns["Topik"].DataPropertyName = "Topics";
                dataGridView1.Columns["Pesan"].DataPropertyName = "Message";
             
                
                dataGridView1.DataSource = logs;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


            }


        }


        private void home(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void log(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();


        }

        private void statistik(object sender, EventArgs e)
        {
            this.Hide();
            Statistic statistic = new Statistic();
            statistic.ShowDialog();

        }
        private void keamanan(object sender, EventArgs e)
        {
            this.Hide();
            New_security keamanan = new New_security();
            keamanan.ShowDialog();
        }

        private void logt(object sender, EventArgs e)
        {

        }

    }
}
