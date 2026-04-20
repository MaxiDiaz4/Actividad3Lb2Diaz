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
    public partial class frmListadoOrdenado : Form
    {
        public frmListadoOrdenado()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (cmbCampo.SelectedIndex)
            {
                case 0:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        Vector.OrdenarPorCodigoAscendente();
                    }
                    else
                    {
                        Vector.OrdenarPorCodigoDescendente();
                    }
                    break;
                case 1:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        Vector.OrdenarPorNombreAscendente();
                    }
                    else
                    {
                        Vector.OrdenarPorNombreDescendente();
                    }
                    break;
                 case 2:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        Vector.OrdenarPorLimiteAscendente();
                    }
                    else
                    {
                        Vector.OrdenarPorLimiteDescendente();
                    }
                    break;
                 case 3:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        Vector.OrdenarDeudaAscendente();
                    }
                    else
                    {
                        Vector.OrdenarPorDeudeDescendente();
                    }
                    break;
            }
            dataGridView1.Rows.Clear();
            for (Int32 i = 0; i < Vector.IND; i++)
            {
                dataGridView1.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Usuario, Vector.Clientes[i].Limite, Vector.Clientes[i].Deuda);
            }
            
        }

        private void gpConsultarDatos_Enter(object sender, EventArgs e)
        {

        }

        private void frmListadoOrdenado_Load(object sender, EventArgs e)
        {
            Vector.CargaDatosDePrueba();
        }
    }
}
