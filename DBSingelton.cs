using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Olsbro_2024
{
    internal class DBSingelton 
    {
        private static SqlConnection Conn;

        public static SqlConnection GetInstance()
        {
            if ((Conn == null) || (Conn.State == ConnectionState.Closed))
            {
                string[] Credentials = XMLReader.ReadConnectionString("..\\..\\connections.xml");
                SqlConnectionStringBuilder ConnString = new SqlConnectionStringBuilder();
                ConnString.UserID = Credentials[0];
                ConnString.Password = Credentials[1];
                ConnString.InitialCatalog = Credentials[2];
                ConnString.DataSource = Credentials[3];

                Conn = new SqlConnection(ConnString.ConnectionString);
                Conn.Open();
            }

            return Conn;
        }

        public static void Close()
        {
            Conn.Close();
            Conn.Dispose();
            Conn = null;
        }
    }
}
