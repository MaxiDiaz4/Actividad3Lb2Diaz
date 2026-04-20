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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void lblPromedioDeuda_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            Vector.CargaDatosDePrueba();
            Listar();
        }
        private void Listar()
        {
            Int32 TotalClientes = 0;
            Decimal Total = 0;
            dgvListadoClientes.Rows.Clear();
            for (Int32 i = 0; i < Vector.Clientes.Length; i++)
            {
                TotalClientes = TotalClientes + 1;
                dgvListadoClientes.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Usuario, Vector.Clientes[i].Deuda, Vector.Clientes[i].Limite);
            }
            int cantidadDatos = 0;
            decimal sumaTotal = 0;

            foreach (DataGridViewRow fila in dgvListadoClientes.Rows)
            {
                // Evitamos contar la fila vacía extra que pone el DataGridView por defecto al final
                if (fila.IsNewRow) continue;

                cantidadDatos++;

               
            }
            lblDeudaMostrar.Text = Total.ToString();
            lblClientesMostrar.Text = cantidadDatos.ToString();
            lblDeuPromedioMostrar.Text = Total.ToString();

        }
    }
    
}
