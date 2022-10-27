namespace pryGrafeuilleIEFI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarNuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBuscarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaDeCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListadoDeTodosLosClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListadoDeClientesDeudores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListadoDeClienteDeUnaCiudad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tssEspecifico = new System.Windows.Forms.ToolStripSeparator();
            this.tssListado = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sistemaToolStripMenuItem.Text = "sistema";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarNuevoCliente,
            this.tssEspecifico,
            this.tsmBuscarCliente,
            this.tsmConsultaDeCliente,
            this.tssListado,
            this.tsmListadoDeTodosLosClientes,
            this.tsmListadoDeClientesDeudores,
            this.tsmListadoDeClienteDeUnaCiudad});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.clienteToolStripMenuItem.Text = "cliente";
            // 
            // tsmAgregarNuevoCliente
            // 
            this.tsmAgregarNuevoCliente.Name = "tsmAgregarNuevoCliente";
            this.tsmAgregarNuevoCliente.Size = new System.Drawing.Size(241, 22);
            this.tsmAgregarNuevoCliente.Text = "agregar nuevo cliente";
            // 
            // tsmBuscarCliente
            // 
            this.tsmBuscarCliente.Name = "tsmBuscarCliente";
            this.tsmBuscarCliente.Size = new System.Drawing.Size(241, 22);
            this.tsmBuscarCliente.Text = "Buscar cliente...";
            // 
            // tsmConsultaDeCliente
            // 
            this.tsmConsultaDeCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.tsmConsultaDeCliente.Name = "tsmConsultaDeCliente";
            this.tsmConsultaDeCliente.Size = new System.Drawing.Size(241, 22);
            this.tsmConsultaDeCliente.Text = "consulta de cliente...";
            this.tsmConsultaDeCliente.Click += new System.EventHandler(this.consultaDeClienteToolStripMenuItem_Click);
            // 
            // tsmListadoDeTodosLosClientes
            // 
            this.tsmListadoDeTodosLosClientes.Name = "tsmListadoDeTodosLosClientes";
            this.tsmListadoDeTodosLosClientes.Size = new System.Drawing.Size(241, 22);
            this.tsmListadoDeTodosLosClientes.Text = "listado de todos los clientes";
            // 
            // tsmListadoDeClientesDeudores
            // 
            this.tsmListadoDeClientesDeudores.Name = "tsmListadoDeClientesDeudores";
            this.tsmListadoDeClientesDeudores.Size = new System.Drawing.Size(241, 22);
            this.tsmListadoDeClientesDeudores.Text = "lsitado de clientes deudores";
            // 
            // tsmListadoDeClienteDeUnaCiudad
            // 
            this.tsmListadoDeClienteDeUnaCiudad.Name = "tsmListadoDeClienteDeUnaCiudad";
            this.tsmListadoDeClienteDeUnaCiudad.Size = new System.Drawing.Size(241, 22);
            this.tsmListadoDeClienteDeUnaCiudad.Text = "listado de cliente de una ciudad";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tssEspecifico
            // 
            this.tssEspecifico.Name = "tssEspecifico";
            this.tssEspecifico.Size = new System.Drawing.Size(238, 6);
            // 
            // tssListado
            // 
            this.tssListado.Name = "tssListado";
            this.tssListado.Size = new System.Drawing.Size(238, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarNuevoCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmBuscarCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaDeCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeTodosLosClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeClientesDeudores;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeClienteDeUnaCiudad;
        private System.Windows.Forms.ToolStripSeparator tssEspecifico;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator tssListado;
    }
}

