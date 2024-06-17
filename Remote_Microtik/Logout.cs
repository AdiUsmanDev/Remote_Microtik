using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lextm.SharpSnmpLib;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Dapper;

namespace logoutmain 
{
    public class Logout
    {
        public int main()
        {

            int selectedData = 0;
            string connectionString = "server=localhost;userid=root;password=root;database=remote_microtik";
            using (MySqlConnection connectionn = new MySqlConnection(connectionString))
            {
                try
                {

                    connectionn.Open();

                    string query = "DELETE FROM auth_sesion";


                    selectedData = connectionn.Execute(query);


                    connectionn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                return selectedData;
            }
        }

    }
    }


