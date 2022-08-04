using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYBD
{
    public class Conn
    {
        public void ConnectToDB()
        {
            string connString = "Host=localhost;Username=postgres;Password=123456789;Database=Internet_shop";
            NpgsqlConnection connection = new NpgsqlConnection(connString);
            connection.Open();
        }

        public void DissconnectToDB()
        {
            string connString = "Host=localhost;Username=postgres;Password=123456789;Database=Internet_shop";
            NpgsqlConnection connection = new NpgsqlConnection(connString);
            connection.Close();
        }
    }
}