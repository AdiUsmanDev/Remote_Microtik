using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Lextm.SharpSnmpLib;
using tik4net;
using tik4net.Objects;
using tik4net.Objects.Interface;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Dapper;
using logoutmain;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace Remote_Microtik
{
    public partial class Form2 : Form
    {
        public string host;
        public string username;
        public string password;
        public int it = 0;
        public bool isAlertShown = false;
        

        private Timer timer;
        private Timer time;
        private ITikConnection connection;

        public Form2()
        {
            InitializeComponent();
            query_data();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer1_Tick;
            timer.Start();


            time = new Timer();
            time.Interval = 2000;
            time.Tick += new EventHandler(timerww);

            inter();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            UpdateData();
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

                    if(selectedData.Any())
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

        private void inter()
        {

            using (connection = ConnectionFactory.CreateConnection(TikConnectionType.Api))
            {
                connection.Open(host, username, password);

                List<Interface> interfaces = connection.LoadAll<Interface>().ToList();


                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Add("Name", "Nama");
                dataGridView1.Columns.Add("Type", "Tipe");
                dataGridView1.Columns.Add("Mtu", "MTU");
                dataGridView1.Columns.Add("RxByte", "Byte Diterima");
                dataGridView1.Columns.Add("TxByte", "Byte Dikirim");

                dataGridView1.Columns["Name"].DataPropertyName = "Name";
                dataGridView1.Columns["Type"].DataPropertyName = "Type";
                dataGridView1.Columns["Mtu"].DataPropertyName = "Mtu";
                dataGridView1.Columns["RxByte"].DataPropertyName = "RxByte";
                dataGridView1.Columns["TxByte"].DataPropertyName = "TxByte";

                dataGridView1.DataSource = interfaces;


            }
        }

        private bool seriesAdded = false;
        private int id = 0;
        private int cp = 0;
        

        private void UpdateData()
        {
            string connectionString = "server=localhost;userid=root;password=root;database=remote_microtik";

            using (connection = ConnectionFactory.CreateConnection(TikConnectionType.Api))
            {
                connection.Open(host, username, password);


                var cpuUsage = connection.LoadSingle<TikCpuUsage>();


                string cpu = $"{cpuUsage.Load}%";
                textBox1.Text = cpu;

                string cc = $"{cpuUsage.Load}";
                cp = int.Parse(cc);


                string uptime = $"{cpuUsage.Uptime}";
                textBox2.Text = uptime;


                string Memori = $"{cpuUsage.memori}";

                textBox3.Text = ConvertBytes(cpuUsage.memori);
            }

            if (!seriesAdded)
            {
                chart1.ChartAreas.Add("MainChartArea");

                Series series1 = new Series
                {
                    Name = "cpu",
                    Color = System.Drawing.Color.Blue,
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 2
                };

                chart1.Series.Add(series1);

                seriesAdded = true;
            }

            chart1.Series["cpu"].Points.AddXY(id, cp);

            id++;

            chart1.ChartAreas["MainChartArea"].AxisX.Enabled = AxisEnabled.False;
           

            connection.Open(host, username, password);




            List<Interface> interfaces = connection.LoadAll<Interface>().ToList();



            var convertedInterfaces = interfaces.Select(i => new
            {
                i.Name,
                i.Type,
                i.Mtu,
                RxByte = ConvertBytes(i.RxByte),
                TxByte = ConvertBytes(i.TxByte)
            }).ToList();

            dataGridView1.Columns["RxByte"].DataPropertyName = "RxByte";
            dataGridView1.Columns["TxByte"].DataPropertyName = "TxByte";

            dataGridView1.DataSource = convertedInterfaces;

            var identity = connection.LoadSingle<SystemIdentity>();
            textBox1_nama.Text = identity.name;



            if (checkBox1.Checked)
            {
              
                //menambahkan timer agar selalu 
                time.Start();
              
               




            }
            else
            {
                time.Stop();

                //lakukan pembukaan firewall
                MySqlConnection connectionn = new MySqlConnection(connectionString);
                connectionn.Open();
                string data = "SELECT * FROM firewall";
                var quer = connectionn.Query(data);

                foreach(var dat in quer)
                {
                    Remove_rule rwmove = new Remove_rule(dat.pesan , dat.port); 
                }

                //MessageBox.Show("semua blok firewall sudah terbuka");

            }


        }


        private void timerww(object sender , EventArgs e)
        {
            detect();
        }


        private void detect()
        {

            string connectionString = "server=localhost;userid=root;password=root;database=remote_microtik";


            using (MySqlConnection connectionn = new MySqlConnection(connectionString))
            {

                connectionn.Open();

                string data = "SELECT * FROM firewall";

                var query = connectionn.Query(data);

                

                List<string> list = new List<string>();

                var logs = connection.LoadList<Log>();

                if (query.Count() != 0)
                {

                   // var portScanLogs = logs.Where(log => log.Message.Contains("Scan ftp terdeteksi"));

                   // if (portScanLogs != null)
                    //{
                        // memunculkan exeute selanjutnya


                    //}

                    foreach (var dat in query)
                    {
                        activate_rule.activate_rule_ac activate = new activate_rule.activate_rule_ac(dat.pesan, dat.port);

                        foreach (var log in logs)
                        {
                            if (log.Message.Contains(dat.pesan))
                            {
                                list.Add(log.Id);
                                string query1 = "INSERT INTO log_serangan (log_serangan) VALUES (@code);";

                                var parameter = new { code = log.Message };
                                connectionn.Execute(query1, parameter);

                                //berikan warning kemanan dan lakukan blok

                                // MessageBox.Show("serangan terdeteksi blok jalur otomatis di aktifkan");

                                //panngiil blok fire wall

                                activate_rule activatee = new activate_rule(dat.pesan, dat.port);


                            }
                        }

                    }

                    foreach (var serangan in list)
                    {

                        connection.CallCommandSync($"/log remove .id={serangan}");

                    }

                }else
                {
                    
                }
             
            }


        }


        



        private void close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private string ConvertBytes(long bytes)
        {
            if (bytes >= 1024 * 1024 * 1024)
                return (bytes / (1024 * 1024 * 1024.0)).ToString("F2") + " GB";
            else if (bytes >= 1024 * 1024)
                return (bytes / (1024 * 1024.0)).ToString("F2") + " MB";
            else if (bytes >= 1024)
                return (bytes / 1024.0).ToString("F2") + " KB";
            else
                return bytes + " Bytes";
        }


        [TikEntity("/system/identity")]
        public class SystemIdentity
        {
            [TikProperty("name")]
            public string name { get; set; }
        }


        [TikEntity("/system/resource")]
        public class TikCpuUsage
        {
            [TikProperty("cpu-load")]
            public int Load { get; set; }

            [TikProperty("uptime")]
            public string Uptime { get; set; }

            [TikProperty("free-memory")]
            public int memori { get; set; }
        }

        [TikEntity("/interface")]
        public class TikInterface
        {
            [TikProperty("name", IsReadOnly = true)]
            public string Name { get; set; }

            [TikProperty("type", IsReadOnly = true)]
            public string Type { get; set; }

            [TikProperty("mtu", IsReadOnly = true)]
            public int Mtu { get; set; }

            [TikProperty("rx-byte", IsReadOnly = true)]
            public long RxBytes { get; set; }

            [TikProperty("tx-byte", IsReadOnly = true)]
            public long TxBytes { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}