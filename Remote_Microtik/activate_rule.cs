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
using MySqlX.XDevAPI.Common;
using MySql.Data.MySqlClient;
using Dapper;
using static System.Windows.Forms.LinkLabel;

namespace Remote_Microtik
{
    public class activate_rule
    {
        private ITikConnection connection;

        public activate_rule(string prams, string port)
        {
            string connectionString = "server=localhost;userid=root;password=root;database=remote_microtik";
            string host = "";
            string username = "";
            string password = "";

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
            }

            using (connection = ConnectionFactory.CreateConnection(TikConnectionType.Api))
            {
                connection.Open(host, username, password);

                var getCommand = connection.CreateCommand("/ip/firewall/filter/print");
                var results = getCommand.ExecuteList();
                string ruleId = null;

                foreach (var result in results)
                {
                    foreach (var kvp in result.Words)
                    {
                        {
                            // MessageBox.Show($"{kvp.Key}: {kvp.Value}");

                            if (result.Words.TryGetValue("comment", out var comment) && comment == prams &&
                                result.Words.TryGetValue("disabled", out var disabled) && disabled == "true")
                            {
                                // Jika komentar sesuai, cek apakah ada key ".id" pada hasil tersebut
                                if (result.Words.TryGetValue(".id", out var id))
                                {
                                    ruleId = id;

                                    //    MessageBox.Show(id);

                                    var disableCommand = connection.CreateCommand("/ip/firewall/filter/set");
                                    disableCommand.AddParameter(".id", id); // Ganti rule_id_disini dengan ID rule yang ingin dinonaktifkan
                                    disableCommand.AddParameter("disabled", "false");
                                    disableCommand.ExecuteNonQuery();

                                    var command = connection.CreateCommandAndParameters("/system/logging/action/set",
                                    "numbers", "memory", "memory-lines", "3");

                                    command.ExecuteNonQuery();
                                    var commandd = connection.CreateCommandAndParameters("/system/logging/action/set",
                                   "numbers", "memory", "memory-lines", "1000");

                                    commandd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
        }

        public class activate_rule_ac
        {
            private ITikConnection connection;

            public activate_rule_ac(string prams, string port)
            {
                string connectionString = "server=localhost;userid=root;password=root;database=remote_microtik";
                string host = "";
                string username = "";
                string password = "";

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
                }

                using (connection = ConnectionFactory.CreateConnection(TikConnectionType.Api))
                {
                    connection.Open(host, username, password);

                    var getCommand = connection.CreateCommand("/ip/firewall/filter/print");
                    var results = getCommand.ExecuteList();
                    string ruleId = null;

                    foreach (var result in results)
                    {
                        foreach (var kvp in result.Words)
                        {
                            {
                                // MessageBox.Show($"{kvp.Key}: {kvp.Value}");

                                if (result.Words.TryGetValue("comment", out var comment) && comment == "Log port " + port + " scanning attempts" &&
                                    result.Words.TryGetValue("disabled", out var disabled) && disabled == "true")
                                {
                                    // Jika komentar sesuai, cek apakah ada key ".id" pada hasil tersebut
                                    if (result.Words.TryGetValue(".id", out var id))
                                    {
                                        ruleId = id;

                                        //    MessageBox.Show(id);

                                        var disableCommand = connection.CreateCommand("/ip/firewall/filter/set");
                                        disableCommand.AddParameter(".id", id); // Ganti rule_id_disini dengan ID rule yang ingin dinonaktifkan
                                        disableCommand.AddParameter("disabled", "false");
                                        disableCommand.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}