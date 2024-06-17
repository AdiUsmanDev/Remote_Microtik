using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tik4net;
using tik4net.Objects;
using Lextm.SharpSnmpLib;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Lextm.SharpSnmpLib.Messaging;
using System.Drawing.Drawing2D;
using tik4net.Objects.Ip;
using Lextm.SharpSnmpLib.Security;
using System.Security.Cryptography;
using System.Threading;
using MySql.Data.MySqlClient;
using Dapper;

namespace Remote_Microtik
{
    public partial class Form1 : Form
    {
        private ITikConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Main(object sender, EventArgs e)
        {
            string subnet = "";
            string adapterName = "Wi-Fi";
            string adapterName2 = "Ethernet";

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.Name == adapterName && adapter.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    UnicastIPAddressInformationCollection addresses = properties.UnicastAddresses;
                    GatewayIPAddressInformationCollection gateways = properties.GatewayAddresses;

                    foreach (UnicastIPAddressInformation address in addresses)
                    {
                        if (address.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            string ipAddress = address.Address.ToString();
                            subnet = ipAddress.Substring(0, ipAddress.LastIndexOf('.') + 1);

                            string defaultGateway = gateways[0].Address.ToString();

                           // MessageBox.Show(defaultGateway);

                            DataGridViewRow row = new DataGridViewRow();

                            row.CreateCells(dataGridView1);
                            row.Cells[0].Value = defaultGateway;
                            row.Cells[1].Value = "8291";
                            row.Cells[2].Value = "Activite";

                            dataGridView1.Rows.Add(row);

                            break;
                        }
                    }

                    if (!string.IsNullOrEmpty(subnet))
                    {
                        break;
                    }
                }
            }

            if (string.IsNullOrEmpty(subnet))
            {
                foreach (NetworkInterface adapter in adapters)
                {
                    if (adapter.Name == adapterName2 && adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        UnicastIPAddressInformationCollection addresses = properties.UnicastAddresses;

                        foreach (UnicastIPAddressInformation address in addresses)
                        {
                            if (address.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                string ipAddress = address.Address.ToString();
                                subnet = ipAddress.Substring(0, ipAddress.LastIndexOf('.') + 1);

                                break;
                            }
                        }

                        if (!string.IsNullOrEmpty(subnet))
                        {
                            break;
                        }
                    }
                }

               // MessageBox.Show(subnet);

                DataGridViewRow row = new DataGridViewRow();
                for (int j = 1; j < 5; j++)
                {
                   string username = "admin";
                    string password = "password";
                    int timeout = 100;
                    int portToCheck = 8291;

                    for (int i = 1; i < 255; i++)
                    {
                        string ipp = subnet + i.ToString();
                        if (await PingAsync(ipp, timeout))
                        {
                            bool isPortOpen = await CheckPortAsync(ipp, portToCheck);
                            if (isPortOpen)
                            {
                                string status = "Port " + portToCheck + " terbuka (MikroTik)";

                                row.CreateCells(dataGridView1);
                                row.Cells[0].Value = ipp;
                                row.Cells[1].Value = portToCheck;
                                row.Cells[2].Value = "Activite";

                                dataGridView1.Rows.Add(row);
                            }
                            else
                            {
                                string status = "Port " + portToCheck + " tertutup";
                            }
                        }
                    }
                }
            }
        }

        private static async Task<bool> PingAsync(string ip, int timeout)
        {
            using (Ping ping = new Ping())
            {
                try
                {
                    PingReply reply = await ping.SendPingAsync(ip, timeout);
                    return reply.Status == IPStatus.Success;
                }
                catch
                {
                    return false;
                }
            }
        }

        private async Task<bool> CheckPortAsync(string ip, int port)
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    await client.ConnectAsync(ip, port);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection = ConnectionFactory.CreateConnection(TikConnectionType.Api);
                connection.Open(textBox1.Text, textBox2.Text, textBox3.Text);
                IsMikroTik(textBox1.Text, textBox2.Text, textBox3.Text);

                insert(textBox1.Text, textBox2.Text, textBox3.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect: " + ex.Message);
            }
        }

        private static bool IsMikroTik(string ip, string username, string password)
        {
            try
            {
                ITikConnection connection = ConnectionFactory.CreateConnection(TikConnectionType.Api);
                connection.Open(ip, username, password);

                var identity = connection.LoadSingle<SystemIdentity>();

                if (identity != null)
                {
                    MessageBox.Show($"Device ip {ip} identified as MikroTik: {identity.Name} apakah sudah benar ?");
                    connection.Close();
                    return true;
                }
                connection.Close();
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string cellValue = row.Cells[e.ColumnIndex].Value.ToString();
                string column1Value = row.Cells[0].Value.ToString();

                textBox1.Text = column1Value;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insert(string ip , string user , string password)
        {

            string connectionString = "server=localhost;userid=root;password=root;database=remote_microtik";
            using (MySqlConnection connectionn = new MySqlConnection(connectionString))
            {
                try
                {
                    connectionn.Open();

                    string query = "INSERT INTO auth_sesion (ip,username,pass,status) VALUES (@ipd, @username,@pass,@status)";

                    var parameter = new { ipd = ip, username = user, pass = password, status = "activate" };

                    var selectedData = connectionn.Execute(query,parameter);

                    if (selectedData > 0)
                    {

                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.ShowDialog();
                      

                    }
                    else
                    {
                        MessageBox.Show("Data gagal  di insert");
                    }

                    connectionn.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            }

        private void close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    [TikEntity("/system/identity")]
    public class SystemIdentity
    {
        [TikProperty("name")]
        public string Name { get; set; }
    }
}