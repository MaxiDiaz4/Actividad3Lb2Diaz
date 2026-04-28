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

        

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (Vector.IND < Vector.Clientes.Length)
            {
                Int32 i = 0;
                while (Vector.Clientes[i].Codigo != Convert.ToInt32(txtCodigo.Text) && i < Vector.IND) // dentro del rango busca el codigo que se escribio
                {
                    i++;
                }
                if (i ==Vector.IND)
                {
                    Vector.Clientes[Vector.IND].Codigo = Convert.ToInt32(txtCodigo.Text);
                    Vector.Clientes[Vector.IND].Usuario = txtUsuario.Text;
                    Vector.Clientes[Vector.IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
                    Vector.Clientes[Vector.IND].Limite = Convert.ToDecimal(txtLimiteDeCredito.Text);
                    Vector.IND++; //IND = IND + 1
                    MessageBox.Show("Cliente cargado correctamente");
                    txtCodigo.Text = "";
                    txtUsuario.Text = "";
                    txtDeuda.Text = "";
                    txtLimiteDeCredito.Text = "";
                }
                else
                {
                    MessageBox.Show("el codigo existe ingrese otro");
                    txtCodigo.Text = "";
                }
                    
            }
            else
            {
                MessageBox.Show("no es posible cargar mas clientes");
            }
            

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           
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
        private void precarga()
        {
            Vector.Clientes[Vector.IND].Codigo = 10;
            Vector.Clientes[Vector.IND].Usuario = "Benja";
            Vector.Clientes[Vector.IND].Deuda = 1000;
            Vector.Clientes[Vector.IND].Limite = 10000;
            Vector.IND++; //IND = IND + 1
            Vector.Clientes[Vector.IND].Codigo = 20;
            Vector.Clientes[Vector.IND].Usuario = "Diego";
            Vector.Clientes[Vector.IND].Deuda = 0;
            Vector.Clientes[Vector.IND].Limite = 20000;
            Vector.IND++; //IND = IND + 1
            Vector.Clientes[Vector.IND].Codigo = 20;
            Vector.Clientes[Vector.IND].Usuario = "Maria";
            Vector.Clientes[Vector.IND].Deuda = 3000;
            Vector.Clientes[Vector.IND].Limite = 30000;
            Vector.IND++; //IND = IND + 1
        }

       

    }
}
