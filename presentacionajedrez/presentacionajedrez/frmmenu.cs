using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacionajedrez
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnhoteles_Click(object sender, EventArgs e)
        {
            FrmHoteles fh = new FrmHoteles();
            fh.ShowDialog();
        }

        private void btnparticipantes_Click(object sender, EventArgs e)
        {
            FrmParticipante fP = new FrmParticipante();
            fP.ShowDialog();
        }

        private void btnpartidas_Click(object sender, EventArgs e)
        {
            FrmPartidas fpa = new FrmPartidas();
            fpa.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
