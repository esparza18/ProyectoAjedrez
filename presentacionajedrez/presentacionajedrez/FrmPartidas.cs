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
    public partial class FrmPartidas : Form
    {
        public static manejadorpartidas _manejadorpartida;
        private partidas _partida;
        public FrmPartidas()
        {
            InitializeComponent();
            _manejadorpartida = new manejadorpartidas();
            _partida = new partidas();
        }

        private void FrmPartidas_Load(object sender, EventArgs e)
        {
            Cargarpartidas("");
        }

        public void Cargarpartidas(string filtro)
        {
            dtgpartidas.DataSource = _manejadorpartida.Obtenerpartidas(filtro);
        }

        private void btnpartidas_Click(object sender, EventArgs e)
        {
            FrmAgregarPartidas fapa = new FrmAgregarPartidas(this);
            fapa.partidaguardar = "guardar";
            fapa.partidaguardar = "actualizar";

            fapa.UpdateEventHandler += fapa_UpdateEventHandler;
            fapa.ShowDialog();
        }
        
        private void fapa_UpdateEventHandler(object sender, FrmAgregarPartidas.UpdateEventArgs args)
        {
            Cargarpartidas("");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Cargarpartidas("");
        }

        private void Eliminar()
        {
            if (MessageBox.Show("Desea eliminar la partida seleccionada", "Eliminar partida", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var categoria = dtgpartidas.CurrentRow.Cells["id"].Value.ToString();
                _manejadorpartida.Eliminarpartidas(categoria);
            }

        }

        private  void dtgpartidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAgregarPartidas fapa = new FrmAgregarPartidas(this);
            fapa.partidaguardar = "actualizar"; 

            fapa.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
