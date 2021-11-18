using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using entidadesajedrez;


namespace accesodatosajedrez
{
    class ajedrezaccesodatos
    {
        conexionaccesodatos _conexion;
        public ajedrezaccesodatos()
        {

            try
            {
                _conexion = new conexionaccesodatos("localhost", "root", "", "", 3306);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la conexion" + ex.Message);
            }
        }


    }
}
