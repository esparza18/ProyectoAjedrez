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
    public partial class FrmAgregarHotel : Form
    {
        private manejadorhoteles _manejadorhotel;
        private hoteles _hotel;

        public static FrmHoteles fh = new FrmHoteles();
        public string partidaguardar;
        public FrmAgregarHotel(FrmHoteles registro)
        {
            InitializeComponent();
            _manejadorhotel = new manejadorhoteles();
            _hotel = new hoteles();
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
                guardarhoteles();
                Close();
            }
            else
            {
                actualizarhoteles();
                Close();
            }
        }

        private void guardarhoteles()
        {
            _hotel.id = txtid.Text;
            _hotel.nombre = txtnombre.Text;
            _hotel.direccion = txtdireccion.Text;
            _hotel.telefono = txttelefono.Text;
            _hotel.entradas = txtentradas.Text;
            _hotel.capacidad = txtcapacidad.Text;
            _hotel.medios = txtmedios.Text;

            var valida = _manejadorhotel.Validarhoteles(_hotel);

            if (valida.Item1)
            {
                _manejadorhotel.Guardarhoteles(_hotel);
            }

            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        private void actualizarhoteles()
        {
            _manejadorhotel.Actualizarhoteles(new hoteles
            {
                id = txtid.Text,
                nombre = txtnombre.Text,
                direccion = txtdireccion.Text,
                telefono = txttelefono.Text,
                entradas = txtentradas.Text,
                capacidad = txtcapacidad.Text,
                medios = txtmedios.Text

            });
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
