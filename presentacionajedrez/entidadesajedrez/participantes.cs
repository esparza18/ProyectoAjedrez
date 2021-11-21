using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesajedrez
{
    public class participantes
    {   
        private string _id;
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _campeonato;
        private string _ocupacion;
        private string _nombrepa;
        private string _num_club;


        public string id { get => _id; set => _id = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string direccion { get => _direccion; set => _direccion = value; }
        public string telefono { get => _telefono; set => _telefono = value; }
        public string campeonato { get => _campeonato; set => _campeonato = value; }
        public string ocupacion { get => _ocupacion; set => _ocupacion = value; }
        public string nombrepa { get => _nombrepa; set => _nombrepa = value; }
        public string num_club { get => _num_club; set => _num_club = value; }

    }
}
