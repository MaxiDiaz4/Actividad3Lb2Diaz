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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }

        private void gpConsultaDatosClientesDeudores_Enter(object sender, EventArgs e)
        {

        }

        private void frmClientesDeudores_Load(object sender, EventArgs e)
        {
            Vector.CargaDatosDePrueba();
        }
       
        private void btnListarDeudores_Click(object sender, EventArgs e)
        {
            Decimal Total = 0;
            dgvClientes.Rows.Clear();
            for (Int32 i = 0; i < Vector.IND; i++)
            {
                if (Vector.Clientes[i].Deuda > 0)
                {
                    dgvClientes.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Usuario, Vector.Clientes[i].Deuda, Vector.Clientes[i].Limite);
                    Total = Total + Vector.Clientes[i].Deuda;
                }

            }
            lblTotalDeuda.Text = Total.ToString();
        }
    }
    
}
