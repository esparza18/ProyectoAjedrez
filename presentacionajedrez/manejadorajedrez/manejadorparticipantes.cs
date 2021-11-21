using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesodatosajedrez;
using entidadesajedrez;

namespace manejadorajedrez
{
    public class manejadorparticipantes
    {
        ajedrezaccesodatos _ajedrezaccesodatos = new ajedrezaccesodatos();

        public Tuple<bool, string> Validarparticipantes(participantes participante)
        {
            bool error = true;
            string cadenaErrores = "";


            if (participante.id.Length == 0 || participante.id == null)
            {
                cadenaErrores = cadenaErrores + "El campo de participantes no puede ser vacio \n";
                error = false;
            }

            if (participante.nombre.Length == 0 || participante.nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo participantes no puede ser vacio \n";
                error = false;
            }

            if (participante.direccion.Length == 0 || participante.direccion == null)
            {
                cadenaErrores = cadenaErrores + "El campo participantesno puede ser vacio \n";
                error = false;
            }

            if (participante.telefono.Length == 0 || participante.telefono == null)
            {
                cadenaErrores = cadenaErrores + "El campo participantes no puede ser vacio \n";
                error = false;
            }

            if (participante.campeonato.Length == 0 || participante.campeonato == null)
            {
                cadenaErrores = cadenaErrores + "El campo participantes no puede ser vacio \n";
                error = false;
            }

            if (participante.ocupacion.Length == 0 || participante.ocupacion == null)
            {
                cadenaErrores = cadenaErrores + "El campo participantes no puede ser vacio \n";
                error = false;
            }

            if (participante.nombrepa.Length == 0 || participante.nombrepa == null)
            {
                cadenaErrores = cadenaErrores + "El campo participantesno puede ser vacio \n";
                error = false;
            }

            if (participante.num_club.Length == 0 || participante.num_club == null)
            {
                cadenaErrores = cadenaErrores + "El campo participantes no puede ser vacio \n";
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
            var listaContactos = _ajedrezaccesodatos.Obtenerparticipantes(filtro);
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

    }

}

