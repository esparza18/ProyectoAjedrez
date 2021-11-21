using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidadesajedrez;
using manejadorajedrez;

namespace presentacionajedrez
{
    public partial class FrmAgregarParticipante : Form
    {
        private manejadorparticipantes _manejadorpartici;
        private participantes _partici;

        public static FrmParticipante fa = new FrmParticipante();
        public string partidaguardar;
        public FrmAgregarParticipante(FrmParticipante registro)
        {
            InitializeComponent();
            _manejadorpartici = new manejadorparticipantes();
            _partici = new participantes();
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (partidaguardar == "guardar")
            {
                guardarparticipantes();
                Close();
            }
            else
            {
                actualizarparticipantes();
                Close();
            }
        }

        public void guardarparticipantes()
        {
            _partici.id = txtid.Text;
            _partici.nombre = txtnombre.Text;
            _partici.direccion = txtdireccion.Text;
            _partici.telefono = txttelefono.Text;
            _partici.campeonato = txtcampeonato.Text;
            _partici.ocupacion = txtocupacion.Text;
            _partici.nombrepa = txtnombrepa.Text;
            _partici.num_club = txtnum_club.Text;

            var valida = _manejadorpartici.Validarparticipantes(_partici);

            if (valida.Item1)
            {
                _manejadorpartici.Guardarparticipantes(_partici);
            }

            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        public void actualizarparticipantes()
        {
            _manejadorpartici.Actualizarparticipantes(new participantes
            {
                id = txtid.Text,
                nombre = txtnombre.Text,
                direccion = txtdireccion.Text,
                telefono = txttelefono.Text,
                campeonato = txtcampeonato.Text,
                ocupacion = txtocupacion.Text,
                nombrepa = txtnombrepa.Text,
                num_club = txtnum_club.Text,
            });
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
