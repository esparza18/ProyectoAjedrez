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
    public partial class FrmParticipante : Form
    {
        public static manejadorparticipantes _manejadorpartici;
        private participantes _partici;
        public FrmParticipante()
        {
            InitializeComponent();
            _manejadorpartici = new manejadorparticipantes();
            _partici = new participantes();
        }

        private void FrmParticipante_Load(object sender, EventArgs e)
        {
            Cargarparticipantes("");
        }

        public void Cargarparticipantes(string filtro)
        {
            dtgparticipantes.DataSource = _manejadorpartici.Obtenerparticipantes(filtro);
        }

        private void fapa_UpdateEventHandler(object sender, FrmAgregarParticipante.UpdateEventArgs args)
        {
            Cargarparticipantes("");
        }

        private void btnparticipante_Click(object sender, EventArgs e)
        {
            FrmAgregarParticipante fapa = new FrmAgregarParticipante(this);
            fapa.partidaguardar = "guardar";
            fapa.UpdateEventHandler += fapa_UpdateEventHandler;
            fapa.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Cargarparticipantes("");
        }

        private void Eliminar()
        {

            if (MessageBox.Show("Desea eliminar al participante seleccionado ", "Eliminar participante", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var categoria = dtgparticipantes.CurrentRow.Cells["id"].Value.ToString();
                _manejadorpartici.Eliminarparticipantes(categoria);
            }
        }

        private void dtgparticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAgregarParticipante fapa = new FrmAgregarParticipante(this);
            fapa.partidaguardar = "actualizar";
            fapa.UpdateEventHandler += fapa_UpdateEventHandler;
            fapa.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
