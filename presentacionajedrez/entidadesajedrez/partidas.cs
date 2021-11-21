using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesajedrez
{
    public class partidas
    {
        
        private string _id;
        private string _cod_p;
        private string _jornada;
        private string _jugada;
        private string _comentario;
        private string _movimiento;

        public string id { get => _id; set => _id = value; }
        public string cod_p { get => _cod_p; set => _cod_p = value; }
        public string jornada { get => _jornada; set => _jornada = value; }
        public string jugada { get => _jugada; set => _jugada = value; }
        public string comentario { get => _comentario; set => _comentario = value; }
        public string movimiento { get => _movimiento; set => _movimiento = value; }

    }
}
