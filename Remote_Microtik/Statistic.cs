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
using MySql.Data.MySqlClient;
using tik4net;
using tik4net.Objects;
using tik4net.Objects.Interface;
using tik4net.Objects.Ip.Firewall;
using tik4net.Objects.System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Dapper;
using logoutmain;

namespace Remote_Microtik
{


    public partial class Statistic : Form
    {
        private ITikConnection connection;
       

        public string username;
        public string password;
        public string host;
      
        public Statistic()
        {
            InitializeComponent();

            query_data();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += cli;
            timer.Start();

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

        private void cli(object sender,  EventArgs e)
        {
            cari_data();
        }

        private bool uss = false;

        private void cari_data()
        {
            using (connection = ConnectionFactory.CreateConnection(TikConnectionType.Api))
            {

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

             

                foreach (var iface in convertedInterfaces)
                    {

                    string seriesName = $"{iface.Name}";
                    string seriesNam = $"{iface.Name} L";
                    Series rxSeries = chart1.Series.FirstOrDefault(s => s.Name == seriesName);
                    Series txSeries = chart1.Series.FirstOrDefault(s => s.Name == seriesNam);


                    if (rxSeries == null)
                    {
                        rxSeries = new Series{

                            Name = seriesName,
                            ChartType = SeriesChartType.Line,
                            BorderWidth = 2
                        }
                        ;
                        chart1.Series.Add(rxSeries);

                        txSeries = new Series
                        {
                            Name = seriesNam,
                            ChartType = SeriesChartType.Line,
                            BorderWidth = 2
                        };
                        
                        chart1.Series.Add(txSeries);
                    }

                    chart1.Series[seriesName].Points.AddXY(seriesName, iface.RxByte);
                    chart1.Series[seriesNam].Points.AddXY(seriesNam, iface.TxByte);

                }
                
         

             
            }



        }

        private double ConvertBytes(long bytes)
        {
            return bytes / (1024 * 1024 * 1024.0);
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
            Form3 form3  =  new Form3();
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

        private void Statistic_Load(object sender, EventArgs e)
        {

        }
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



}
