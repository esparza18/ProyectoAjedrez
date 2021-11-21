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
    public partial class FrmAgregarPartidas : Form
    {
        private manejadorpartidas _manejadorpartida;
        private partidas _partida;

        public static FrmPartidas fa = new FrmPartidas();
        public string partidaguardar;
        public FrmAgregarPartidas(FrmPartidas registro)
        {
            InitializeComponent();
            _manejadorpartida = new manejadorpartidas();
            _partida = new partidas();
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        public void btnguardar_Click(object sender, EventArgs e)
        {
            if (partidaguardar == "guardar")
            {
                guardarpartidas();
                Close();
            }
            else
            {
                actualizarpartida();
                Close();
            }
        }

        public void guardarpartidas()
        {

            _partida.id = txtid.Text;
            _partida.cod_p = txtcod_p.Text;
            _partida.jornada = txtjornada.Text;
            _partida.jugada = txtjugada.Text;
            _partida.comentario = txtcomentario.Text;
            _partida.movimiento = txtmovimiento.Text;

            var valida = _manejadorpartida.Validarpartidas(_partida);

            if (valida.Item1)
            {
                _manejadorpartida.Guardarpartidas(_partida);
            }

            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        private void actualizarpartida()
        {
            _manejadorpartida.Actualizarpartidas(new partidas
            {
                id = txtid.Text,
                cod_p = txtcod_p.Text,
                jornada = txtjornada.Text,
                jugada = txtjugada.Text,
                comentario = txtcomentario.Text,
                movimiento = txtmovimiento.Text,

        });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
