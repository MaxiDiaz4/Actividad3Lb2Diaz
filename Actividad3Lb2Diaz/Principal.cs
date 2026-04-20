using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3Lb2Diaz
{
    public partial class frmManejoClientes : Form
    {
        public frmManejoClientes()
        {
            InitializeComponent();
        }

        private void agregarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
           //formulario.MdiParent = this;
            formulario.Show();

        }

        private void listadoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmClientesDeudores();
            formulario.Show();
        }

        private void listadoDeClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Ordenados = new frmListadoOrdenado();
            Ordenados.MdiParent = this;
            Ordenados.Show();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario= new frmListadoClientes();
            formulario.Show();
            
        }

        private void frmManejoClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
