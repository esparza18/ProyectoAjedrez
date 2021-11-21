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
    public partial class FrmHoteles : Form
    {
        public static manejadorhoteles _manejadorhotel;
        private hoteles _hotel;
        public FrmHoteles()
        {
            InitializeComponent();
            _manejadorhotel = new manejadorhoteles();
            _hotel = new hoteles();
        }

        private void FrmHoteles_Load(object sender, EventArgs e)
        {
            Cargarhoteles("");
        }

        public void Cargarhoteles(string filtro)
        {
            dtghoteles.DataSource = _manejadorhotel.Obtenerhoteles(filtro);
        }

        private void fapa_UpdateEventHandler(object sender, FrmAgregarHotel.UpdateEventArgs args)
        {
            Cargarhoteles("");
        }

        private void btnhoteles_Click(object sender, EventArgs e)
        {
            FrmAgregarHotel fah = new FrmAgregarHotel(this);
            fah.partidaguardar = "guardar";
            fah.UpdateEventHandler += fapa_UpdateEventHandler;
            fah.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar la partida seleccionada", "Eliminar partida", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var categoria = dtghoteles.CurrentRow.Cells["id"].Value.ToString();
                _manejadorhotel.Eliminarhoteles(categoria);
            }
        }

        private void dtghoteles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAgregarHotel fah = new FrmAgregarHotel(this);
            fah.partidaguardar = "actualizar";

            fah.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
