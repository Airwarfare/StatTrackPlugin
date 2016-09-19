using MySql.Data.MySqlClient;
using Rocket.Core.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StatTracker
{
    class DatabaseMgr
    {
        public static DatabaseMgr Instance;

        public string datatxt = string.Empty;

        public void DatabaseMgrFunction()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;

            string myConnectionString;

            myConnectionString = "server:74.201.57.223;uid=root;" + "pwd=test123;database=Unturned;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                Logger.LogWarning("Connection Established!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Logger.LogWarning(ex.ToString());
            }
        }

        public void InfoTesting()
        {
            Logger.Log("2");
            string sql = " SELECT * FROM playertrackingtest   ";
            Logger.Log("3");
            MySqlConnection con = new MySqlConnection("server:74.201.57.223;uid=root;pwd=test123;database=Unturned;");
            Logger.Log("4");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            Logger.Log("5");

            con.Open();
            Logger.Log("6");
            MySqlDataReader reader = cmd.ExecuteReader();
            Logger.Log("7");

            while (reader.Read())
            {
                datatxt += reader.GetString("kill");
                Logger.LogWarning(datatxt);
            }

        }
    }
}
