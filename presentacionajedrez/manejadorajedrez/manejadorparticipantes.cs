using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesodatosajedrez;
using entidadesajedrez;

namespace manejadorajedrez
{
    class manejadorparticipantes
    {
        ajedrezaccesodatos _ajedrezaccesodatos = new ajedrezaccesodatos();

        public Tuple<bool, string> Validarparticipantes(participantes participante)
        {
            bool error = true;
            string cadenaErrores = "";


            if (participantes.Nombre.Length == 0 || participantes.Nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la descripcion no puede ser vacio \n";
                error = false;
            }

            if (participantes.Apellidop.Length == 0 || participantes.Apellidop == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (participantes.Apellidom.Length == 0 || participantes.Apellidom == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (participantes.Fechanacimiento.Length == 0 || participantes.Fechanacimiento == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (participantes.Rfc.Length == 0 || participantes.Rfc == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (participantes.Contrasena.Length == 0 || participantes.Contrasena == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }


            if (participantes.Fkidaccesos.Length == 0 || participantes.Fkidaccesos == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }




            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }

        public void Guardarparticipantes(participantes participante)
        {
            try
            {
                _ajedrezaccesodatos.Guardarparticipantes(participante);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public List<participantes> Obtenerparticipantes(string filtro)
        {
            var listaContactos = _ajedrezaccesodatos.Obtenerpartidas(filtro);
            return listaContactos;
        }

        public void Actualizarparticipantes(participantes participante)
        {
            try
            {
                _ajedrezaccesodatos.Actualizarparticipantes(participante);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public void Eliminarparticipantes(string participante)
        {
            try
            {
                _ajedrezaccesodatos.Eliminarparticipantes(participante);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public bool Existeparticipantes(participantes participante)
        {
            var existe = _ajedrezaccesodatos.Existeparticipantes(participante);
            return existe;
        }

    }

}

