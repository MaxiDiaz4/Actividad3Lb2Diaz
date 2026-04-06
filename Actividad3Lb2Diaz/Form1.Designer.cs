namespace Actividad3Lb2Diaz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCargaDeDatos = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtLimiteDeCredito = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.txtTotalDeuda = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCargaDeDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCargaDeDatos
            // 
            this.gbCargaDeDatos.Controls.Add(this.btnCargar);
            this.gbCargaDeDatos.Controls.Add(this.txtLimiteDeCredito);
            this.gbCargaDeDatos.Controls.Add(this.txtUsuario);
            this.gbCargaDeDatos.Controls.Add(this.lblLimite);
            this.gbCargaDeDatos.Controls.Add(this.lblUsuario);
            this.gbCargaDeDatos.Controls.Add(this.txtDeuda);
            this.gbCargaDeDatos.Controls.Add(this.txtCodigo);
            this.gbCargaDeDatos.Controls.Add(this.lblDeuda);
            this.gbCargaDeDatos.Controls.Add(this.lblCodigo);
            this.gbCargaDeDatos.Location = new System.Drawing.Point(50, 36);
            this.gbCargaDeDatos.Name = "gbCargaDeDatos";
            this.gbCargaDeDatos.Size = new System.Drawing.Size(511, 198);
            this.gbCargaDeDatos.TabIndex = 0;
            this.gbCargaDeDatos.TabStop = false;
            this.gbCargaDeDatos.Text = "Carga de datos";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(22, 48);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(22, 105);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(42, 13);
            this.lblDeuda.TabIndex = 1;
            this.lblDeuda.Text = "Deuda:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(71, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(70, 98);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(100, 20);
            this.txtDeuda.TabIndex = 3;
            this.txtDeuda.TextChanged += new System.EventHandler(this.txtDeuda_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(239, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(239, 105);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(87, 13);
            this.lblLimite.TabIndex = 5;
            this.lblLimite.Text = "Limite de credito:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(305, 41);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(123, 20);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtLimiteDeCredito
            // 
            this.txtLimiteDeCredito.Location = new System.Drawing.Point(352, 102);
            this.txtLimiteDeCredito.Name = "txtLimiteDeCredito";
            this.txtLimiteDeCredito.Size = new System.Drawing.Size(76, 20);
            this.txtLimiteDeCredito.TabIndex = 7;
            this.txtLimiteDeCredito.TextChanged += new System.EventHandler(this.txtLimiteDeCredito_TextChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(370, 156);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(82, 23);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.txtTotalDeuda);
            this.groupBox1.Controls.Add(this.lblTotalDeuda);
            this.groupBox1.Controls.Add(this.dgvClientes);
            this.groupBox1.Location = new System.Drawing.Point(50, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 335);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de datos";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Usuario,
            this.Deuda,
            this.Limite});
            this.dgvClientes.Location = new System.Drawing.Point(25, 19);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(448, 206);
            this.dgvClientes.TabIndex = 0;
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Location = new System.Drawing.Point(285, 251);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(82, 13);
            this.lblTotalDeuda.TabIndex = 1;
            this.lblTotalDeuda.Text = "Total de deuda:";
            // 
            // txtTotalDeuda
            // 
            this.txtTotalDeuda.Location = new System.Drawing.Point(373, 248);
            this.txtTotalDeuda.Name = "txtTotalDeuda";
            this.txtTotalDeuda.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDeuda.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(389, 288);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Limite de credito";
            this.Deuda.Name = "Deuda";
            // 
            // Limite
            // 
            this.Limite.HeaderText = "Limite";
            this.Limite.Name = "Limite";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCargaDeDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCargaDeDatos.ResumeLayout(false);
            this.gbCargaDeDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCargaDeDatos;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblCodigo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtLimiteDeCredito;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtTotalDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
    }
}

