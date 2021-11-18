using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace accesodatosajedrez
{
    public class conexionaccesodatos
    {

        private MySqlConnection _conn;

        public conexionaccesodatos(string server, string user, string password, string database, uint port)
        {
            MySqlConnectionStringBuilder cadenaConexion = new MySqlConnectionStringBuilder();

            cadenaConexion.Server = server;
            cadenaConexion.UserID = user;
            cadenaConexion.Password = password;
            cadenaConexion.Database = database;
            cadenaConexion.Port = port;

            _conn = new MySqlConnection(cadenaConexion.ToString());
        }

        public void EjecutarConsulta(string consulta)
        {
            _conn.Open();
            var command = new MySqlCommand(consulta, _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public DataSet ObtenerDatos(string consulta, string tabla)
        {
            var ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, _conn);
            da.Fill(ds, tabla);
            return ds;
        }

        public int Existencia(string consulta)
        {
            _conn.Open();
            var command = new MySqlCommand(consulta, _conn);
            var res = Convert.ToInt32(command.ExecuteScalar().ToString());
            _conn.Close();
            return res;
        }
    }

}

