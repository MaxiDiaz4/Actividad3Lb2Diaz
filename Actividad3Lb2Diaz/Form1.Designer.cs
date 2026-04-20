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
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtLimiteDeCredito = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbCargaDeDatos.SuspendLayout();
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
            // txtLimiteDeCredito
            // 
            this.txtLimiteDeCredito.Location = new System.Drawing.Point(352, 102);
            this.txtLimiteDeCredito.Name = "txtLimiteDeCredito";
            this.txtLimiteDeCredito.Size = new System.Drawing.Size(76, 20);
            this.txtLimiteDeCredito.TabIndex = 7;
            this.txtLimiteDeCredito.TextChanged += new System.EventHandler(this.txtLimiteDeCredito_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(305, 41);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(123, 20);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
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
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(239, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(70, 98);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(100, 20);
            this.txtDeuda.TabIndex = 3;
            this.txtDeuda.TextChanged += new System.EventHandler(this.txtDeuda_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(71, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(22, 48);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 257);
            this.Controls.Add(this.gbCargaDeDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCargaDeDatos.ResumeLayout(false);
            this.gbCargaDeDatos.PerformLayout();
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
    }
}

