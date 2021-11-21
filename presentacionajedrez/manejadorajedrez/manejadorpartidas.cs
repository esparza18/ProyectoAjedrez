using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesodatosajedrez;
using entidadesajedrez;

namespace manejadorajedrez
{
    public class manejadorpartidas
    {
        ajedrezaccesodatos _ajedrezaccesodatos = new ajedrezaccesodatos();

        public Tuple<bool, string> Validarpartidas(partidas partida)
        {
            bool error = true;
            string cadenaErrores = "";


            if (partida.id.Length == 0 || partida.id == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la partida no puede ser vacio \n";
                error = false;
            }

            if (partida.cod_p.Length == 0 || partida.cod_p == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la partida no puede ser vacio \n";
                error = false;
            }

            if (partida.jornada.Length == 0 || partida.jornada == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la partida no puede ser vacio \n";
                error = false;
            }

            if (partida.jugada.Length == 0 || partida.jugada == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la partida no puede ser vacio \n";
                error = false;
            }

            if (partida.comentario.Length == 0 || partida.comentario == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la partida no puede ser vacio \n";
                error = false;
            }

            if (partida.movimiento.Length == 0 || partida.movimiento == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la partida no puede ser vacio \n";
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


    }
}
