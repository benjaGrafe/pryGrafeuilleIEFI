namespace pryGrafeuilleIEFI
{
    partial class frmBusquedaDeCliente
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
            this.lblCodigoCLiente = new System.Windows.Forms.Label();
            this.lblNombreB = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.lblRTANombre = new System.Windows.Forms.Label();
            this.lblRTALimiteCreditp = new System.Windows.Forms.Label();
            this.lblRTADeuda = new System.Windows.Forms.Label();
            this.txtCLIENTE = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoCLiente
            // 
            this.lblCodigoCLiente.AutoSize = true;
            this.lblCodigoCLiente.Location = new System.Drawing.Point(9, 37);
            this.lblCodigoCLiente.Name = "lblCodigoCLiente";
            this.lblCodigoCLiente.Size = new System.Drawing.Size(93, 13);
            this.lblCodigoCLiente.TabIndex = 0;
            this.lblCodigoCLiente.Text = "codigo del cliente:";
            // 
            // lblNombreB
            // 
            this.lblNombreB.AutoSize = true;
            this.lblNombreB.Location = new System.Drawing.Point(16, 44);
            this.lblNombreB.Name = "lblNombreB";
            this.lblNombreB.Size = new System.Drawing.Size(45, 13);
            this.lblNombreB.TabIndex = 1;
            this.lblNombreB.Text = "nombre:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(16, 90);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(42, 13);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Location = new System.Drawing.Point(16, 144);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(87, 13);
            this.lblLimiteCredito.TabIndex = 3;
            this.lblLimiteCredito.Text = "Limite de credito:";
            // 
            // lblRTANombre
            // 
            this.lblRTANombre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRTANombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRTANombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRTANombre.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblRTANombre.Location = new System.Drawing.Point(107, 43);
            this.lblRTANombre.Name = "lblRTANombre";
            this.lblRTANombre.Size = new System.Drawing.Size(128, 19);
            this.lblRTANombre.TabIndex = 4;
            this.lblRTANombre.Text = "dnjns";
            // 
            // lblRTALimiteCreditp
            // 
            this.lblRTALimiteCreditp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRTALimiteCreditp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRTALimiteCreditp.Location = new System.Drawing.Point(107, 144);
            this.lblRTALimiteCreditp.Name = "lblRTALimiteCreditp";
            this.lblRTALimiteCreditp.Size = new System.Drawing.Size(128, 19);
            this.lblRTALimiteCreditp.TabIndex = 5;
            this.lblRTALimiteCreditp.Text = "label6";
            // 
            // lblRTADeuda
            // 
            this.lblRTADeuda.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRTADeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRTADeuda.Location = new System.Drawing.Point(107, 90);
            this.lblRTADeuda.Name = "lblRTADeuda";
            this.lblRTADeuda.Size = new System.Drawing.Size(128, 19);
            this.lblRTADeuda.TabIndex = 6;
            this.lblRTADeuda.Text = "label7";
            // 
            // txtCLIENTE
            // 
            this.txtCLIENTE.Location = new System.Drawing.Point(131, 34);
            this.txtCLIENTE.Name = "txtCLIENTE";
            this.txtCLIENTE.Size = new System.Drawing.Size(137, 20);
            this.txtCLIENTE.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(131, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 31);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombreB);
            this.groupBox1.Controls.Add(this.lblDeuda);
            this.groupBox1.Controls.Add(this.lblLimiteCredito);
            this.groupBox1.Controls.Add(this.lblRTALimiteCreditp);
            this.groupBox1.Controls.Add(this.lblRTADeuda);
            this.groupBox1.Controls.Add(this.lblRTANombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 192);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 339);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(148, 339);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // frmBusquedaDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 374);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCLIENTE);
            this.Controls.Add(this.lblCodigoCLiente);
            this.Name = "frmBusquedaDeCliente";
            this.Text = "frmBusquedaDeCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoCLiente;
        private System.Windows.Forms.Label lblNombreB;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.Label lblRTANombre;
        private System.Windows.Forms.Label lblRTALimiteCreditp;
        private System.Windows.Forms.Label lblRTADeuda;
        private System.Windows.Forms.TextBox txtCLIENTE;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
    }
}