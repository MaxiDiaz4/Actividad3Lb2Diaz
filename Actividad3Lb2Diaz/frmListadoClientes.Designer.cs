namespace Actividad3Lb2Diaz
{
    partial class frmListadoClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpConsultaDatos = new System.Windows.Forms.GroupBox();
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblDeudaMostrar = new System.Windows.Forms.Label();
            this.lblClientesMostrar = new System.Windows.Forms.Label();
            this.lblDeuPromedioMostrar = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gpConsultaDatos
            // 
            this.gpConsultaDatos.Controls.Add(this.lblDeuPromedioMostrar);
            this.gpConsultaDatos.Controls.Add(this.lblClientesMostrar);
            this.gpConsultaDatos.Controls.Add(this.lblDeudaMostrar);
            this.gpConsultaDatos.Controls.Add(this.lblCantidadClientes);
            this.gpConsultaDatos.Controls.Add(this.lblPromedioDeuda);
            this.gpConsultaDatos.Controls.Add(this.lblTotalDeuda);
            this.gpConsultaDatos.Controls.Add(this.dgvListadoClientes);
            this.gpConsultaDatos.Location = new System.Drawing.Point(38, 32);
            this.gpConsultaDatos.Name = "gpConsultaDatos";
            this.gpConsultaDatos.Size = new System.Drawing.Size(468, 427);
            this.gpConsultaDatos.TabIndex = 0;
            this.gpConsultaDatos.TabStop = false;
            this.gpConsultaDatos.Text = "Consulta De Datos";
            // 
            // dgvListadoClientes
            // 
            this.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvListadoClientes.Location = new System.Drawing.Point(35, 36);
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.Size = new System.Drawing.Size(404, 247);
            this.dgvListadoClientes.TabIndex = 0;
            this.dgvListadoClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Location = new System.Drawing.Point(217, 309);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(84, 13);
            this.lblTotalDeuda.TabIndex = 1;
            this.lblTotalDeuda.Text = "Total de Deuda:";
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(217, 385);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(104, 13);
            this.lblPromedioDeuda.TabIndex = 2;
            this.lblPromedioDeuda.Text = "Promedio de Deuda:";
            this.lblPromedioDeuda.Click += new System.EventHandler(this.lblPromedioDeuda_Click);
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Location = new System.Drawing.Point(217, 345);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(107, 13);
            this.lblCantidadClientes.TabIndex = 3;
            this.lblCantidadClientes.Text = "Cantidad de Clientes:";
            // 
            // lblDeudaMostrar
            // 
            this.lblDeudaMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeudaMostrar.Location = new System.Drawing.Point(370, 309);
            this.lblDeudaMostrar.Name = "lblDeudaMostrar";
            this.lblDeudaMostrar.Size = new System.Drawing.Size(57, 14);
            this.lblDeudaMostrar.TabIndex = 4;
            // 
            // lblClientesMostrar
            // 
            this.lblClientesMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClientesMostrar.Location = new System.Drawing.Point(370, 345);
            this.lblClientesMostrar.Name = "lblClientesMostrar";
            this.lblClientesMostrar.Size = new System.Drawing.Size(57, 13);
            this.lblClientesMostrar.TabIndex = 5;
            // 
            // lblDeuPromedioMostrar
            // 
            this.lblDeuPromedioMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeuPromedioMostrar.Location = new System.Drawing.Point(367, 384);
            this.lblDeuPromedioMostrar.Name = "lblDeuPromedioMostrar";
            this.lblDeuPromedioMostrar.Size = new System.Drawing.Size(60, 13);
            this.lblDeuPromedioMostrar.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Usuario";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Limite de credito";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.Name = "Column4";
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 543);
            this.Controls.Add(this.gpConsultaDatos);
            this.Name = "frmListadoClientes";
            this.Text = "frmListadoClientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            this.gpConsultaDatos.ResumeLayout(false);
            this.gpConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpConsultaDatos;
        private System.Windows.Forms.DataGridView dgvListadoClientes;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblDeuPromedioMostrar;
        private System.Windows.Forms.Label lblClientesMostrar;
        private System.Windows.Forms.Label lblDeudaMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}