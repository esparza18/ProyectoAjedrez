using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesajedrez
{
    public class hoteles
    {
        private string _id;
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _entradas;
        private string _capacidad;
        private string _medios;


        public string id { get => _id; set => _id = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string direccion { get => _direccion; set => _direccion = value; }
        public string telefono { get => _telefono; set => _telefono = value; }
        public string entradas { get => _entradas; set => _entradas = value; }
        public string capacidad { get => _capacidad; set => _capacidad = value; }
        public string medios { get => _medios; set => _medios = value; }

    }
}
