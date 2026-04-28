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
            //Ordenados.MdiParent = this;
            Ordenados.Show();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListadoClientes();
            formulario.Show();

        }

        private void frmManejoClientes_Load(object sender, EventArgs e)
        {
            PrecargarDatos();
        }

      
       
        public void PrecargarDatos()
        {
            // Verifica que el índice sea 0 para no duplicar datos si el form se abre más de una vez
            if (Vector.IND == 0)
            {
                Vector.Clientes[Vector.IND].Codigo = 10;
                Vector.Clientes[Vector.IND].Usuario = "Ana";
                Vector.Clientes[Vector.IND].Deuda = 1000;
                Vector.Clientes[Vector.IND].Limite = 10000;
                Vector.IND++;

                Vector.Clientes[Vector.IND].Codigo = 20;
                Vector.Clientes[Vector.IND].Usuario = "Diego";
                Vector.Clientes[Vector.IND].Deuda = 0;
                Vector.Clientes[Vector.IND].Limite = 20000;
                Vector.IND++;

                Vector.Clientes[Vector.IND].Codigo = 30;
                Vector.Clientes[Vector.IND].Usuario = "Maria";
                Vector.Clientes[Vector.IND].Deuda = 3000;
                Vector.Clientes[Vector.IND].Limite = 30000;
                Vector.IND++;
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
