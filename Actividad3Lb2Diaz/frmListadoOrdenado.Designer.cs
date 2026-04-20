namespace Actividad3Lb2Diaz
{
    partial class frmListadoOrdenado
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
            this.gpConsultarDatos = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbModo = new System.Windows.Forms.ComboBox();
            this.lblModo = new System.Windows.Forms.Label();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpConsultarDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpConsultarDatos
            // 
            this.gpConsultarDatos.Controls.Add(this.btnListar);
            this.gpConsultarDatos.Controls.Add(this.dataGridView1);
            this.gpConsultarDatos.Controls.Add(this.cmbModo);
            this.gpConsultarDatos.Controls.Add(this.lblModo);
            this.gpConsultarDatos.Controls.Add(this.cmbCampo);
            this.gpConsultarDatos.Controls.Add(this.lblCampo);
            this.gpConsultarDatos.Location = new System.Drawing.Point(73, 32);
            this.gpConsultarDatos.Name = "gpConsultarDatos";
            this.gpConsultarDatos.Size = new System.Drawing.Size(610, 445);
            this.gpConsultarDatos.TabIndex = 1;
            this.gpConsultarDatos.TabStop = false;
            this.gpConsultarDatos.Text = "Consulta de datos";
            this.gpConsultarDatos.Enter += new System.EventHandler(this.gpConsultarDatos_Enter);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(412, 401);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(54, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 262);
            this.dataGridView1.TabIndex = 4;
            // 
            // cmbModo
            // 
            this.cmbModo.FormattingEnabled = true;
            this.cmbModo.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cmbModo.Location = new System.Drawing.Point(280, 63);
            this.cmbModo.Name = "cmbModo";
            this.cmbModo.Size = new System.Drawing.Size(100, 21);
            this.cmbModo.TabIndex = 3;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Location = new System.Drawing.Point(240, 66);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(34, 13);
            this.lblModo.TabIndex = 2;
            this.lblModo.Text = "Modo";
            // 
            // cmbCampo
            // 
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Limite",
            "Deuda"});
            this.cmbCampo.Location = new System.Drawing.Point(97, 63);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(100, 21);
            this.cmbCampo.TabIndex = 1;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(51, 66);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo";
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
            // frmListadoOrdenado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 514);
            this.Controls.Add(this.gpConsultarDatos);
            this.IsMdiContainer = true;
            this.Name = "frmListadoOrdenado";
            this.Text = "frmListadoOrdenado";
            this.Load += new System.EventHandler(this.frmListadoOrdenado_Load);
            this.gpConsultarDatos.ResumeLayout(false);
            this.gpConsultarDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpConsultarDatos;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Label lblCampo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbModo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}