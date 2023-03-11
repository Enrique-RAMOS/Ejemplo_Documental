using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Lebra
{
    public static class Conexion
    {
        public static IDbConnection conectarr()
        {
            IDbConnection connection;
            var cadena = ConfigurationManager.ConnectionStrings["lebra"].ConnectionString;
            connection = new SqlConnection(cadena);
            return connection;
        }

        public static string conexion = @"data source=.;initial catalog=Lebra;Integrated Security=true";
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }















    }

}
