using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Xml.Linq;
//using MySqlConnector;
using MySql.Data.MySqlClient;

namespace API.Models
{
    public class Conexao
    {
        public MySqlConnection cn;

        public Conexao()
        {
            /*var server = "localhost";
            var database = "UNIP_LPBD";
            var uid = "root";
            var password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";*/
            cn = new MySqlConnection("server=localhost;database=UNIP_LPBD;username=root;password=;");
        }

        public MySqlConnection Conectar()
        {
            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }
            return cn;
        }

        public MySqlConnection Desconectar()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
            return cn;
        }
    }
}