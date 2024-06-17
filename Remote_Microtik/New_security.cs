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
using tik4net;
using tik4net.Objects;
using Dapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using logoutmain;
using Lextm.SharpSnmpLib;

namespace Remote_Microtik
{
    public partial class New_security : Form
    {
        public string host;
        public string username;
        public string password;
        public New_security()
        {
            InitializeComponent();
            qq();

        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void qq()
        {
            string connectionString = "server=localhost;userid=root;password=root;database=remote_microtik";

            using (MySqlConnection connectionn = new MySqlConnection(connectionString))
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

                connectionn.Close();


            }

        }

        private void main(object sender, EventArgs e)
        {

            var port = textBox1.Text;
            var address = textBox2.Text;
            var pesan = textBox3.Text;

           if(port != null)
            {
                if (address != null)
                {
                    tambah(port, address,pesan);
                }
            }


        }


        private void tambah(string portid, string addd, string pesan)
        {
            


                using (var connection = ConnectionFactory.CreateConnection(TikConnectionType.Api))
                {

                    connection.Open(host,username,password);


                    var command = connection.CreateCommand("/ip/firewall/address-list/add");
                    command.AddParameter("list", addd);
                    command.AddParameter("address", "0.0.0.0");
                    command.AddParameter("comment", "IP Address to block");
                    command.ExecuteNonQuery();


                    // Perintah pertama: Menambahkan filter untuk mendeteksi scanning pada port 21
                    var command1 = connection.CreateCommand("/ip/firewall/filter/add");
                    command1.AddParameter("chain", "input");
                    command1.AddParameter("protocol", "tcp");
                    command1.AddParameter("dst-port", portid);
                    command1.AddParameter("connection-state", "new");
                    command1.AddParameter("limit", "10,5:packet");
                    command1.AddParameter("action", "add-src-to-address-list");
                    command1.AddParameter("address-list", addd);
                    command1.AddParameter("address-list-timeout", "1h");
                    command1.AddParameter("comment", "Detect port" + portid +"scanning and add to ScanList");
                    command1.ExecuteNonQuery();


                    var command2 = connection.CreateCommand("/ip/firewall/filter/add");
                    command2.AddParameter("chain", "input");
                    command2.AddParameter("src-address-list", addd);
                    command2.AddParameter("action", "log");
                    command2.AddParameter("log-prefix", pesan);
                    command2.AddParameter("comment", "Log port "+ portid +" scanning attempts");
                    command2.ExecuteNonQuery();


                    var command3 = connection.CreateCommand("/ip/firewall/filter/add");
                    command3.AddParameter("chain", "input");
                    command3.AddParameter("src-address-list", addd);
                    command3.AddParameter("action", "drop");
                    command3.AddParameter("disabled", "true");
                    command3.AddParameter("comment", pesan );
                    command3.ExecuteNonQuery();


                simpanid(portid, pesan, addd);

                }
            }
            

        



        private void simpanid (string port, string pesan ,string addres)
        {
      
            string connectionString = "server=localhost;userid=root;password=root;database=remote_microtik";
            using (MySqlConnection connectionnn = new MySqlConnection(connectionString))
            {
                try
                {
                    connectionnn.Open();
                    
                    string query55 = "INSERT INTO firewall (port,address,pesan) VALUES (@ipd,@add,@pes)";

                    var parameter = new { ipd = port, add = addres, pes = pesan};

                    int selectedData = connectionnn.Execute(query55,parameter);

                    if (selectedData > 0)
                    {
                        MessageBox.Show("berhasil menambakan rule firewall dan di terapkan ke microtik");
                    }
                    else
                    {
                        MessageBox.Show("gagal menambakan rule firewall dan di terapkan ke microtik");
                    }
                         
                }
 
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }

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
            Logout keluar = new Logout();
            int log = keluar.main();

            if (log > 0)
            {


                this.Hide();
                Form1 frm1 = new Form1();
                frm1.ShowDialog();


            }
            else
            {
                MessageBox.Show("gagal logout");
            }
        }

        private void New_security_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

    




