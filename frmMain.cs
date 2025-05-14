using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryControlAcceso
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        int contadorTiempo = 0;
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirVentanaArchivos();
        }

        public void AbrirVentanaArchivos()
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblArchivoSeleccionado.Text = openFileDialog1.FileName;
            }
           
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            AbrirVentanaArchivos();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            contadorTiempo++;
            lblTimer.Text = contadorTiempo.ToString();
        }

        private void btnTarea_Click(object sender, EventArgs e)
        {
            if (temporizador.Enabled == true)
            { 
                temporizador.Enabled = false;
            }
            else 
            {
                temporizador.Enabled = true;
            }
        }
    }
}
