using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesodatosajedrez;
using entidadesajedrez;

namespace manejadorajedrez
{
    public class manejadorhoteles
    {
        ajedrezaccesodatos _ajedrezaccesodatos = new ajedrezaccesodatos();

        public Tuple<bool, string> Validarhoteles(hoteles hotel)
        {
            bool error = true;
            string cadenaErrores = "";


            if (hotel.id.Length == 0 || hotel.nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo del hotel no puede ser vacio \n";
                error = false;
            }
            if (hotel.nombre.Length == 0 || hotel.nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo del hotel no puede ser vacio \n";
                error = false;
            }

            if (hotel.direccion.Length == 0 || hotel.direccion == null)
            {
                cadenaErrores = cadenaErrores + "El campo del hotel no puede ser vacio \n";
                error = false;
            }

            if (hotel.telefono.Length == 0 || hotel.telefono == null)
            {
                cadenaErrores = cadenaErrores + "El campo del hotel no puede ser vacio \n";
                error = false;
            }

            if (hotel.entradas.Length == 0 || hotel.entradas == null)
            {
                cadenaErrores = cadenaErrores + "El campo del hotel no puede ser vacio \n";
                error = false;
            }

            if (hotel.capacidad.Length == 0 || hotel.capacidad == null)
            {
                cadenaErrores = cadenaErrores + "El campo del hotel no puede ser vacio \n";
                error = false;
            }

            if (hotel.medios.Length == 0 || hotel.medios == null)
            {
                cadenaErrores = cadenaErrores + "El campo del hotel no puede ser vacio \n";
                error = false;
            }

            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }

        public void Guardarhoteles(hoteles hotel)
        {
            try
            {
                _ajedrezaccesodatos.Guardarhoteles(hotel);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public List<hoteles> Obtenerhoteles(string filtro)
        {
            var listaContactos = _ajedrezaccesodatos.Obtenerhoteles(filtro);
            return listaContactos;
        }

        public void Actualizarhoteles(hoteles hotel)
        {
            try
            {
                _ajedrezaccesodatos.Actualizarhoteles(hotel);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public void Eliminarhoteles(string hotel)
        {
            try
            {
                _ajedrezaccesodatos.Eliminarhoteles(hotel);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

    }

}

