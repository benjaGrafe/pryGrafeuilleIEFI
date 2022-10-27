namespace pryGrafeuilleIEFI
{
    partial class NuevoCliente
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
            this.grbCargaDatos = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtLimitesCreditos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblLimitecredito = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbCargaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCargaDatos
            // 
            this.grbCargaDatos.Controls.Add(this.button2);
            this.grbCargaDatos.Controls.Add(this.btnAgregar);
            this.grbCargaDatos.Controls.Add(this.cmbCiudad);
            this.grbCargaDatos.Controls.Add(this.txtLimitesCreditos);
            this.grbCargaDatos.Controls.Add(this.txtNombre);
            this.grbCargaDatos.Controls.Add(this.lblCiudad);
            this.grbCargaDatos.Controls.Add(this.lblLimitecredito);
            this.grbCargaDatos.Controls.Add(this.lblNombre);
            this.grbCargaDatos.Location = new System.Drawing.Point(28, 20);
            this.grbCargaDatos.Name = "grbCargaDatos";
            this.grbCargaDatos.Size = new System.Drawing.Size(434, 226);
            this.grbCargaDatos.TabIndex = 0;
            this.grbCargaDatos.TabStop = false;
            this.grbCargaDatos.Text = "Carga de datos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "me arrepenti";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(119, 197);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregara Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(119, 137);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(238, 21);
            this.cmbCiudad.TabIndex = 5;
            // 
            // txtLimitesCreditos
            // 
            this.txtLimitesCreditos.Location = new System.Drawing.Point(119, 89);
            this.txtLimitesCreditos.Name = "txtLimitesCreditos";
            this.txtLimitesCreditos.Size = new System.Drawing.Size(100, 20);
            this.txtLimitesCreditos.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(297, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(18, 140);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 2;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblLimitecredito
            // 
            this.lblLimitecredito.AutoSize = true;
            this.lblLimitecredito.Location = new System.Drawing.Point(18, 92);
            this.lblLimitecredito.Name = "lblLimitecredito";
            this.lblLimitecredito.Size = new System.Drawing.Size(95, 13);
            this.lblLimitecredito.TabIndex = 1;
            this.lblLimitecredito.Text = "Limimte de crédito:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre y Apellido:";
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 299);
            this.Controls.Add(this.grbCargaDatos);
            this.Name = "NuevoCliente";
            this.Text = "Form2";
            this.grbCargaDatos.ResumeLayout(false);
            this.grbCargaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCargaDatos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.TextBox txtLimitesCreditos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblLimitecredito;
        private System.Windows.Forms.Label lblNombre;
    }
}