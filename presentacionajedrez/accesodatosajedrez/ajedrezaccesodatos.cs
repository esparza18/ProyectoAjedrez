using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using entidadesajedrez;


namespace accesodatosajedrez
{
    public class ajedrezaccesodatos
    {
        conexionaccesodatos _conexion;
        public ajedrezaccesodatos()
        {

            try
            {
                _conexion = new conexionaccesodatos("localhost", "root", "", "CLUBAJEDREZ", 3306);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la conexion" + ex.Message);
            }
        }

        //---------------------------------METODO PARA HOTELES----------------------------------------------

        public void Guardarhoteles(hoteles hotel)
        {
            try
            {
                string consulta = string.Format("insert into hoteles values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    hotel.id, hotel.nombre, hotel.direccion, hotel.telefono, hotel.entradas, hotel.capacidad, hotel.medios);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public void Eliminarhoteles(string hotel)
        {
            try
            {
                string consulta = string.Format("delete from hoteles where id ='{0}')", hotel);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public void Actualizarhoteles(hoteles hotel)
        {
            try
            {
                string consulta = string.Format("update hoteles set  nombre = '{1}',direccion = '{2}',telefono = '{3}',entradas = '{4}',capacidad = '{5}',medios = '{6}' where id = '{0}'",
                hotel.id, hotel.nombre, hotel.direccion, hotel.telefono, hotel.entradas, hotel.capacidad, hotel.medios);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public List<hoteles> Obtenerhoteles(string filtro)
        {
            var Listahoteles = new List<hoteles>();
            var ds = new DataSet();
            string consulta = string.Format("select * from hoteles where id like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "id");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {

                var hotel = new hoteles
                {
                    id = row["id"].ToString(),
                    nombre = row["nombre"].ToString(),
                    direccion = row["direccion"].ToString(),
                    telefono = row["telefono"].ToString(),
                    entradas = row["entradas"].ToString(),
                    capacidad = row["capacidad"].ToString(),
                    medios = row["medios"].ToString(),

                };


                Listahoteles.Add(hotel);

            }

            return Listahoteles;
        }

        //--------------------METODO PARA PARTICIPANTES-----------------------------------------------------------------

        public void Guardarparticipantes(participantes participante)
        {
            try
            {
                string consulta = string.Format("insert into participantes values ('{0}','{1}','{2}','{3}','{4}','{5}',,'{6}','{7}')",
                    participante.id, participante.nombre, participante.direccion, participante.telefono, participante.campeonato, participante.ocupacion, participante.nombrepa, participante.num_club);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public void Eliminarparticipantes(string participante)
        {
            try
            {
                string consulta = string.Format("delete from participantes where id ='{0}')", participante);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public void Actualizarparticipantes(participantes participante)
        {
            try
            {
                string consulta = string.Format("update participantes set nombre = '{1}', direccion = '{2}'," +
                    " telefono= '{3}',campeonato  = '{4}',ocupacion  = '{5}',nombrepa  = '{6}',num_club  = '{7}'" +
                    " where id = '{0}'",
                participante.nombre, participante.direccion, participante.telefono, participante.campeonato, participante.ocupacion, participante.nombrepa, participante.num_club, participante.id);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public List<participantes> Obtenerparticipantes(string filtro)
        {
            var Listaparticipantes = new List<participantes>();
            var ds = new DataSet();
            string consulta = string.Format("select * from participantes where id like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "id");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {

                var participante = new participantes
                {
                    id = row["id"].ToString(),
                    nombre = row["nombre"].ToString(),
                    direccion = row["direccion"].ToString(),
                    telefono = row["telefono"].ToString(),
                    campeonato = row["campeonato"].ToString(),
                    ocupacion = row["ocupacion"].ToString(),
                    nombrepa = row["nombrepa"].ToString(),
                    num_club = row["num_club"].ToString(),
                };


                Listaparticipantes.Add(participante);

            }

            return Listaparticipantes;
        }


        //--------------------METODO PARA PARTIDAS-----------------------------------------------------------------

        public void Guardarpartidas(partidas partida)
        {
            try
            {
                string consulta = string.Format("insert into partidas values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    partida.id, partida.cod_p, partida.jornada, partida.jugada, partida.comentario, partida.movimiento);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public void Eliminarpartidas(string partida)
        {
            try
            {
                string consulta = string.Format("delete from partida where id ='{0}'", partida);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public void Actualizarpartidas(partidas partida)
        {
            try
            {
                string consulta = string.Format("update from partidas set cod_p = '{1}',jornada = '{2}',jugada = '{3}',comentario = '{4}',movimiento = '{5}' where id = '{0}'",
                partida.cod_p, partida.jornada, partida.jugada, partida.comentario, partida.movimiento, partida.id);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public List<partidas> Obtenerpartidas(string filtro)
        {
            var Listapartidas = new List<partidas>();
            var ds = new DataSet();
            string consulta = string.Format("select * from partidas where id like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "id");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {

                var partida = new partidas
                {
                    id = row["id"].ToString(),
                    cod_p = row["cod_p"].ToString(),
                    jornada = row["jornada"].ToString(),
                    jugada = row["jugada"].ToString(),
                    comentario = row["comentario"].ToString(),
                    movimiento = row["movimiento"].ToString(),
                };


                Listapartidas.Add(partida);

            }

            return Listapartidas;
        }


    }
}

