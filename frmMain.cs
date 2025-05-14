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
    }
}
