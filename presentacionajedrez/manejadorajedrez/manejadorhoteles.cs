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


            if (hoteles.Nombre.Length == 0 || hoteles.Nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la descripcion no puede ser vacio \n";
                error = false;
            }

            if (hoteles.Apellidop.Length == 0 || hoteles.Apellidop == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (hoteles.Apellidom.Length == 0 || hoteles.Apellidom == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (hoteles.Fechanacimiento.Length == 0 || hoteles.Fechanacimiento == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (hoteles.Rfc.Length == 0 || hoteles.Rfc == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (hoteles.Contrasena.Length == 0 || hoteles.Contrasena == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }


            if (hoteles.Fkidaccesos.Length == 0 || hoteles.Fkidaccesos == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
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

        public bool Existehoteles(hoteles hotel)
        {
            var existe = _ajedrezaccesodatos.Existehoteles(hotel);
            return existe;
        }

    }

}

