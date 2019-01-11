namespace Electricidad_Inversores_y_Paneles
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
            this.transformadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDePotenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeBobinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeTransformadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeBateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiempoDeDuracionDelInversorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiempoDeCargaDeInversorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transformadorToolStripMenuItem,
            this.bateriaToolStripMenuItem,
            this.inversorToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transformadorToolStripMenuItem
            // 
            this.transformadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculoDePotenciaToolStripMenuItem,
            this.calculoDeBobinaToolStripMenuItem,
            this.calculoDeTransformadorToolStripMenuItem});
            this.transformadorToolStripMenuItem.Name = "transformadorToolStripMenuItem";
            this.transformadorToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.transformadorToolStripMenuItem.Text = "Transformador";
            // 
            // calculoDePotenciaToolStripMenuItem
            // 
            this.calculoDePotenciaToolStripMenuItem.Name = "calculoDePotenciaToolStripMenuItem";
            this.calculoDePotenciaToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.calculoDePotenciaToolStripMenuItem.Text = "Calculo de Potencia";
            this.calculoDePotenciaToolStripMenuItem.Click += new System.EventHandler(this.calculoDePotenciaToolStripMenuItem_Click);
            // 
            // calculoDeBobinaToolStripMenuItem
            // 
            this.calculoDeBobinaToolStripMenuItem.Name = "calculoDeBobinaToolStripMenuItem";
            this.calculoDeBobinaToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.calculoDeBobinaToolStripMenuItem.Text = "Calculo de Transformador para Inversores";
            this.calculoDeBobinaToolStripMenuItem.Click += new System.EventHandler(this.calculoDeBobinaToolStripMenuItem_Click);
            // 
            // calculoDeTransformadorToolStripMenuItem
            // 
            this.calculoDeTransformadorToolStripMenuItem.Name = "calculoDeTransformadorToolStripMenuItem";
            this.calculoDeTransformadorToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.calculoDeTransformadorToolStripMenuItem.Text = "Calculo de Transformador ";
            this.calculoDeTransformadorToolStripMenuItem.Click += new System.EventHandler(this.calculoDeTransformadorToolStripMenuItem_Click);
            // 
            // bateriaToolStripMenuItem
            // 
            this.bateriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaDeBateriaToolStripMenuItem});
            this.bateriaToolStripMenuItem.Name = "bateriaToolStripMenuItem";
            this.bateriaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.bateriaToolStripMenuItem.Text = "Bateria";
            // 
            // cargaDeBateriaToolStripMenuItem
            // 
            this.cargaDeBateriaToolStripMenuItem.Name = "cargaDeBateriaToolStripMenuItem";
            this.cargaDeBateriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargaDeBateriaToolStripMenuItem.Text = "Carga de Bateria";
            this.cargaDeBateriaToolStripMenuItem.Click += new System.EventHandler(this.cargaDeBateriaToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // inversorToolStripMenuItem
            // 
            this.inversorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiempoDeDuracionDelInversorToolStripMenuItem,
            this.tiempoDeCargaDeInversorToolStripMenuItem});
            this.inversorToolStripMenuItem.Name = "inversorToolStripMenuItem";
            this.inversorToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.inversorToolStripMenuItem.Text = "Inversor";
            // 
            // tiempoDeDuracionDelInversorToolStripMenuItem
            // 
            this.tiempoDeDuracionDelInversorToolStripMenuItem.Name = "tiempoDeDuracionDelInversorToolStripMenuItem";
            this.tiempoDeDuracionDelInversorToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.tiempoDeDuracionDelInversorToolStripMenuItem.Text = "Tiempo de duracion del inversor";
            this.tiempoDeDuracionDelInversorToolStripMenuItem.Click += new System.EventHandler(this.tiempoDeDuracionDelInversorToolStripMenuItem_Click);
            // 
            // tiempoDeCargaDeInversorToolStripMenuItem
            // 
            this.tiempoDeCargaDeInversorToolStripMenuItem.Name = "tiempoDeCargaDeInversorToolStripMenuItem";
            this.tiempoDeCargaDeInversorToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.tiempoDeCargaDeInversorToolStripMenuItem.Text = "Tiempo de carga de inversor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transformadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDePotenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeBateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDeBobinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDeTransformadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiempoDeDuracionDelInversorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiempoDeCargaDeInversorToolStripMenuItem;
    }
}

