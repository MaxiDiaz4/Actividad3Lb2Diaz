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
            Listar();
        }
        private void Listar()
        {
            Int32 TotalClientes = 0;
            Decimal Total = 0;
            dgvConsulta.Rows.Clear();
            for (Int32 i = 0; i < Vector.IND; i++)
            {
                dgvConsulta.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Usuario, Vector.Clientes[i].Limite, Vector.Clientes[i].Deuda);
                Total = Total + Vector.Clientes[i].Deuda;
                
                
                TotalClientes++;



                
            }
           
            lblDeudaMostrar.Text = Total.ToString();
            lblClientesMostrar.Text = TotalClientes.ToString();
            lblDeuPromedioMostrar.Text = (Total / TotalClientes).ToString();

        }
    }
    
}
