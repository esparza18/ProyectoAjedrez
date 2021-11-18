using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesodatosajedrez;
using entidadesajedrez;

namespace manejadorajedrez
{
    class manejadorpartidas
    {
        ajedrezaccesodatos _ajedrezaccesodatos = new ajedrezaccesodatos();

        public Tuple<bool, string> Validarpartidas(partidas partida)
        {
            bool error = true;
            string cadenaErrores = "";


            if (partidas.Nombre.Length == 0 || partidas.Nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la descripcion no puede ser vacio \n";
                error = false;
            }

            if (partidas.Apellidop.Length == 0 || partidas.Apellidop == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (partidas.Apellidom.Length == 0 || partidas.Apellidom == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (partidas.Fechanacimiento.Length == 0 || partidas.Fechanacimiento == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (partidas.Rfc.Length == 0 || partidas.Rfc == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (partidas.Contrasena.Length == 0 || partidas.Contrasena == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }


            if (partidas.Fkidaccesos.Length == 0 || partidas.Fkidaccesos == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }




            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }

        public void Guardarpartidas(partidas partida)
        {
            try
            {
                _ajedrezaccesodatos.Guardarpartidas(partida);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public List<partidas> Obtenerpartidas(string filtro)
        {
            var listaContactos = _ajedrezaccesodatos.Obtenerpartidas(filtro);
            return listaContactos;
        }

        public void Actualizarpartidas(partidas partida)
        {
            try
            {
                _ajedrezaccesodatos.Actualizarpartidas(partida);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public void Eliminarpartidas(string partida)
        {
            try
            {
                _ajedrezaccesodatos.Eliminarpartidas(partida);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public bool Existepartidas(partidas partida)
        {
            var existe = _ajedrezaccesodatos.Existepartidas(partida);
            return existe;
        }

    }
}
