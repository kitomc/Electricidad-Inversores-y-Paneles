namespace Electricidad_Inversores_y_Paneles
{
    partial class TiempoDeDuracionInversor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVoltajeAlimentacion = new System.Windows.Forms.TextBox();
            this.tbAmperesBaterias = new System.Windows.Forms.TextBox();
            this.tbPotenciaRealConsumo = new System.Windows.Forms.TextBox();
            this.lbTiempoHora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voltaje de alimentacion del  Inversor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amepres de las Baterias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Potencia Real de Consumo";
            // 
            // tbVoltajeAlimentacion
            // 
            this.tbVoltajeAlimentacion.Location = new System.Drawing.Point(250, 42);
            this.tbVoltajeAlimentacion.Name = "tbVoltajeAlimentacion";
            this.tbVoltajeAlimentacion.Size = new System.Drawing.Size(100, 20);
            this.tbVoltajeAlimentacion.TabIndex = 3;
            // 
            // tbAmperesBaterias
            // 
            this.tbAmperesBaterias.Location = new System.Drawing.Point(250, 84);
            this.tbAmperesBaterias.Name = "tbAmperesBaterias";
            this.tbAmperesBaterias.Size = new System.Drawing.Size(100, 20);
            this.tbAmperesBaterias.TabIndex = 4;
            // 
            // tbPotenciaRealConsumo
            // 
            this.tbPotenciaRealConsumo.Location = new System.Drawing.Point(250, 124);
            this.tbPotenciaRealConsumo.Name = "tbPotenciaRealConsumo";
            this.tbPotenciaRealConsumo.Size = new System.Drawing.Size(100, 20);
            this.tbPotenciaRealConsumo.TabIndex = 5;
            // 
            // lbTiempoHora
            // 
            this.lbTiempoHora.AutoSize = true;
            this.lbTiempoHora.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempoHora.ForeColor = System.Drawing.Color.Red;
            this.lbTiempoHora.Location = new System.Drawing.Point(447, 76);
            this.lbTiempoHora.Name = "lbTiempoHora";
            this.lbTiempoHora.Size = new System.Drawing.Size(25, 28);
            this.lbTiempoHora.TabIndex = 6;
            this.lbTiempoHora.Text = "0";
            this.lbTiempoHora.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Su Tiempo de trabajo es de ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TiempoDeDuracionInversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 216);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTiempoHora);
            this.Controls.Add(this.tbPotenciaRealConsumo);
            this.Controls.Add(this.tbAmperesBaterias);
            this.Controls.Add(this.tbVoltajeAlimentacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TiempoDeDuracionInversor";
            this.Text = "TiempoDeFuncionamientoInversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVoltajeAlimentacion;
        private System.Windows.Forms.TextBox tbAmperesBaterias;
        private System.Windows.Forms.TextBox tbPotenciaRealConsumo;
        private System.Windows.Forms.Label lbTiempoHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}