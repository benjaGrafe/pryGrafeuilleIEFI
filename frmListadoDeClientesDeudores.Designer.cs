namespace pryGrafeuilleIEFI
{
    partial class frmListadoDeClientesDeudores
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Columncliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotalDeuda = new System.Windows.Forms.Label();
            this.lblCantidadCliente = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblRTAtotalDeuda = new System.Windows.Forms.Label();
            this.lblRTACantidadCleinte = new System.Windows.Forms.Label();
            this.lblRTAPromedioDeuda = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columncliente,
            this.ColumnNombre,
            this.ColumnDeuda});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // Columncliente
            // 
            this.Columncliente.HeaderText = "Código";
            this.Columncliente.Name = "Columncliente";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre y Apellido";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.Width = 101;
            // 
            // ColumnDeuda
            // 
            this.ColumnDeuda.HeaderText = "Deuda";
            this.ColumnDeuda.Name = "ColumnDeuda";
            // 
            // lbltotalDeuda
            // 
            this.lbltotalDeuda.AutoSize = true;
            this.lbltotalDeuda.Location = new System.Drawing.Point(326, 367);
            this.lbltotalDeuda.Name = "lbltotalDeuda";
            this.lbltotalDeuda.Size = new System.Drawing.Size(80, 13);
            this.lbltotalDeuda.TabIndex = 1;
            this.lbltotalDeuda.Text = "total de Deuda:";
            // 
            // lblCantidadCliente
            // 
            this.lblCantidadCliente.AutoSize = true;
            this.lblCantidadCliente.Location = new System.Drawing.Point(326, 404);
            this.lblCantidadCliente.Name = "lblCantidadCliente";
            this.lblCantidadCliente.Size = new System.Drawing.Size(104, 13);
            this.lblCantidadCliente.TabIndex = 2;
            this.lblCantidadCliente.Text = "Cantidad De Cleinte:";
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(326, 439);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(104, 13);
            this.lblPromedioDeuda.TabIndex = 3;
            this.lblPromedioDeuda.Text = "Promedio de Deuda:";
            // 
            // lblRTAtotalDeuda
            // 
            this.lblRTAtotalDeuda.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRTAtotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRTAtotalDeuda.Location = new System.Drawing.Point(443, 360);
            this.lblRTAtotalDeuda.Name = "lblRTAtotalDeuda";
            this.lblRTAtotalDeuda.Size = new System.Drawing.Size(103, 20);
            this.lblRTAtotalDeuda.TabIndex = 4;
            this.lblRTAtotalDeuda.Text = "label4";
            // 
            // lblRTACantidadCleinte
            // 
            this.lblRTACantidadCleinte.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRTACantidadCleinte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRTACantidadCleinte.Location = new System.Drawing.Point(443, 397);
            this.lblRTACantidadCleinte.Name = "lblRTACantidadCleinte";
            this.lblRTACantidadCleinte.Size = new System.Drawing.Size(103, 20);
            this.lblRTACantidadCleinte.TabIndex = 5;
            this.lblRTACantidadCleinte.Text = "label5";
            // 
            // lblRTAPromedioDeuda
            // 
            this.lblRTAPromedioDeuda.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRTAPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRTAPromedioDeuda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRTAPromedioDeuda.Location = new System.Drawing.Point(443, 438);
            this.lblRTAPromedioDeuda.Name = "lblRTAPromedioDeuda";
            this.lblRTAPromedioDeuda.Size = new System.Drawing.Size(103, 20);
            this.lblRTAPromedioDeuda.TabIndex = 6;
            this.lblRTAPromedioDeuda.Text = "label6";
            // 
            // btnListo
            // 
            this.btnListo.Location = new System.Drawing.Point(443, 465);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(103, 27);
            this.btnListo.TabIndex = 7;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            // 
            // frmListadoDeClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 504);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.lblRTAPromedioDeuda);
            this.Controls.Add(this.lblRTACantidadCleinte);
            this.Controls.Add(this.lblRTAtotalDeuda);
            this.Controls.Add(this.lblPromedioDeuda);
            this.Controls.Add(this.lblCantidadCliente);
            this.Controls.Add(this.lbltotalDeuda);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmListadoDeClientesDeudores";
            this.Text = "frmListadoDeClientesDeudores";
            this.Load += new System.EventHandler(this.frmListadoDeClientesDeudores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columncliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeuda;
        private System.Windows.Forms.Label lbltotalDeuda;
        private System.Windows.Forms.Label lblCantidadCliente;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblRTAtotalDeuda;
        private System.Windows.Forms.Label lblRTACantidadCleinte;
        private System.Windows.Forms.Label lblRTAPromedioDeuda;
        private System.Windows.Forms.Button btnListo;
    }
}