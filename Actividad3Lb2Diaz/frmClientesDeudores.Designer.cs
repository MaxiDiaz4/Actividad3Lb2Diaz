namespace Actividad3Lb2Diaz
{
    partial class frmClientesDeudores
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
            this.gpConsultaDatosClientesDeudores = new System.Windows.Forms.GroupBox();
            this.btnListarDeudores = new System.Windows.Forms.Button();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblPromedioDeDeuda = new System.Windows.Forms.Label();
            this.lblCantidadDeClientes = new System.Windows.Forms.Label();
            this.lblTotalDeDeuda = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpConsultaDatosClientesDeudores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gpConsultaDatosClientesDeudores
            // 
            this.gpConsultaDatosClientesDeudores.Controls.Add(this.btnListarDeudores);
            this.gpConsultaDatosClientesDeudores.Controls.Add(this.lblPromedioDeuda);
            this.gpConsultaDatosClientesDeudores.Controls.Add(this.lblCantidadClientes);
            this.gpConsultaDatosClientesDeudores.Controls.Add(this.lblTotalDeuda);
            this.gpConsultaDatosClientesDeudores.Controls.Add(this.lblPromedioDeDeuda);
            this.gpConsultaDatosClientesDeudores.Controls.Add(this.lblCantidadDeClientes);
            this.gpConsultaDatosClientesDeudores.Controls.Add(this.lblTotalDeDeuda);
            this.gpConsultaDatosClientesDeudores.Controls.Add(this.dgvClientes);
            this.gpConsultaDatosClientesDeudores.Location = new System.Drawing.Point(65, 12);
            this.gpConsultaDatosClientesDeudores.Name = "gpConsultaDatosClientesDeudores";
            this.gpConsultaDatosClientesDeudores.Size = new System.Drawing.Size(483, 474);
            this.gpConsultaDatosClientesDeudores.TabIndex = 0;
            this.gpConsultaDatosClientesDeudores.TabStop = false;
            this.gpConsultaDatosClientesDeudores.Text = "Consulta de Datos";
            this.gpConsultaDatosClientesDeudores.Enter += new System.EventHandler(this.gpConsultaDatosClientesDeudores_Enter);
            // 
            // btnListarDeudores
            // 
            this.btnListarDeudores.Location = new System.Drawing.Point(360, 410);
            this.btnListarDeudores.Name = "btnListarDeudores";
            this.btnListarDeudores.Size = new System.Drawing.Size(84, 35);
            this.btnListarDeudores.TabIndex = 7;
            this.btnListarDeudores.Text = "Listar Deudores";
            this.btnListarDeudores.UseVisualStyleBackColor = true;
            this.btnListarDeudores.Click += new System.EventHandler(this.btnListarDeudores_Click_1);
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(360, 374);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(84, 13);
            this.lblPromedioDeuda.TabIndex = 6;
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadClientes.Location = new System.Drawing.Point(360, 337);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(84, 13);
            this.lblCantidadClientes.TabIndex = 5;
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.Location = new System.Drawing.Point(360, 303);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(84, 13);
            this.lblTotalDeuda.TabIndex = 4;
            // 
            // lblPromedioDeDeuda
            // 
            this.lblPromedioDeDeuda.AutoSize = true;
            this.lblPromedioDeDeuda.Location = new System.Drawing.Point(232, 374);
            this.lblPromedioDeDeuda.Name = "lblPromedioDeDeuda";
            this.lblPromedioDeDeuda.Size = new System.Drawing.Size(104, 13);
            this.lblPromedioDeDeuda.TabIndex = 3;
            this.lblPromedioDeDeuda.Text = "Promedio de Deuda:";
            // 
            // lblCantidadDeClientes
            // 
            this.lblCantidadDeClientes.AutoSize = true;
            this.lblCantidadDeClientes.Location = new System.Drawing.Point(232, 337);
            this.lblCantidadDeClientes.Name = "lblCantidadDeClientes";
            this.lblCantidadDeClientes.Size = new System.Drawing.Size(107, 13);
            this.lblCantidadDeClientes.TabIndex = 2;
            this.lblCantidadDeClientes.Text = "Cantidad de Clientes:";
            // 
            // lblTotalDeDeuda
            // 
            this.lblTotalDeDeuda.AutoSize = true;
            this.lblTotalDeDeuda.Location = new System.Drawing.Point(232, 303);
            this.lblTotalDeDeuda.Name = "lblTotalDeDeuda";
            this.lblTotalDeDeuda.Size = new System.Drawing.Size(84, 13);
            this.lblTotalDeDeuda.TabIndex = 1;
            this.lblTotalDeDeuda.Text = "Total de Deuda:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvClientes.Location = new System.Drawing.Point(31, 35);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(426, 253);
            this.dgvClientes.TabIndex = 0;
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
            this.Column3.HeaderText = "Limite de Credito";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.Name = "Column4";
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.gpConsultaDatosClientesDeudores);
            this.Name = "frmClientesDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientesDeudores";
            this.Load += new System.EventHandler(this.frmClientesDeudores_Load);
            this.gpConsultaDatosClientesDeudores.ResumeLayout(false);
            this.gpConsultaDatosClientesDeudores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpConsultaDatosClientesDeudores;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblPromedioDeDeuda;
        private System.Windows.Forms.Label lblCantidadDeClientes;
        private System.Windows.Forms.Label lblTotalDeDeuda;
        private System.Windows.Forms.Button btnListarDeudores;
    }
}