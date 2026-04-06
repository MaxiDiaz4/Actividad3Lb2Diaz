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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declaracion de un registro
        private struct RegCli
            {
            public Int32 Codigo;
            public String Usuario;
            public Decimal Deuda;
            public Decimal Limite;
            }
        //Declaracion del vector

        private RegCli[] Clientes = new RegCli[10];

        //Declaracion del indice

        private Int32 IND = 0;

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (IND < Clientes.Length)
            {
                Clientes[IND].Codigo = Convert.ToInt32(txtCodigo.Text);
                Clientes[IND].Usuario = txtUsuario.Text;
                Clientes[IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
                Clientes[IND].Limite = Convert.ToDecimal(txtLimiteDeCredito.Text);
                IND++; //IND = IND + 1
                Listar();
                MessageBox.Show("los datos se cargaron correctamente");
                txtCodigo.Text = "";
                txtUsuario.Text = "";
                txtDeuda.Text = "";
                txtLimiteDeCredito.Text= "";
            }
            else
            {
                MessageBox.Show("no es posible cargar mas datos");
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            Decimal Total = 0;
            dgvClientes.Rows.Clear();
            for (Int32 i = 0; i < Clientes.Length; i++)
            {
                dgvClientes.Rows.Add(Clientes[i].Codigo, Clientes[i].Usuario, Clientes[i].Deuda, Clientes[i].Limite);
                Total = Total + Clientes[i].Deuda;
            }
            lblTotalDeuda.Text = Total.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
        }

        private void comprobar()
        {
            if (txtCodigo.Text != "" && txtUsuario.Text != "" && txtDeuda.Text != "" && txtLimiteDeCredito.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }
            
	
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            comprobar();    
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtLimiteDeCredito_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }
    }
}
