namespace Electricidad_Inversores_y_Paneles
{
    partial class Calculo_Potencia_Transformador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculo_Potencia_Transformador));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Calculo_Potencia = new System.Windows.Forms.Button();
            this.Ancho_Chappa = new System.Windows.Forms.TextBox();
            this.Largo_Chappa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Potencia_Real_Chappa = new System.Windows.Forms.Label();
            this.Potencia_Aparente_Chappa = new System.Windows.Forms.Label();
            this.Seccion_Chappa = new System.Windows.Forms.Label();
            this.Numero_Chappa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Largo de la Chapa (A)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seccion del Nucleo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Potencia Aparente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Potencia Real";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btn_Calculo_Potencia);
            this.groupBox1.Controls.Add(this.Ancho_Chappa);
            this.groupBox1.Controls.Add(this.Largo_Chappa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(444, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info de Chappa";
            // 
            // btn_Calculo_Potencia
            // 
            this.btn_Calculo_Potencia.Location = new System.Drawing.Point(337, 98);
            this.btn_Calculo_Potencia.Name = "btn_Calculo_Potencia";
            this.btn_Calculo_Potencia.Size = new System.Drawing.Size(106, 23);
            this.btn_Calculo_Potencia.TabIndex = 5;
            this.btn_Calculo_Potencia.Text = "Calcular Potencia";
            this.btn_Calculo_Potencia.UseVisualStyleBackColor = true;
            this.btn_Calculo_Potencia.Click += new System.EventHandler(this.btn_Calculo_Potencia_Click);
            // 
            // Ancho_Chappa
            // 
            this.Ancho_Chappa.Location = new System.Drawing.Point(140, 71);
            this.Ancho_Chappa.Name = "Ancho_Chappa";
            this.Ancho_Chappa.Size = new System.Drawing.Size(95, 20);
            this.Ancho_Chappa.TabIndex = 4;
            // 
            // Largo_Chappa
            // 
            this.Largo_Chappa.Location = new System.Drawing.Point(140, 35);
            this.Largo_Chappa.Name = "Largo_Chappa";
            this.Largo_Chappa.Size = new System.Drawing.Size(95, 20);
            this.Largo_Chappa.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Grosor de la Chappa (D)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numero De Chappa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Potencia_Real_Chappa);
            this.groupBox2.Controls.Add(this.Potencia_Aparente_Chappa);
            this.groupBox2.Controls.Add(this.Seccion_Chappa);
            this.groupBox2.Controls.Add(this.Numero_Chappa);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(444, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 185);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Potencia de Chappa E";
            // 
            // Potencia_Real_Chappa
            // 
            this.Potencia_Real_Chappa.AutoSize = true;
            this.Potencia_Real_Chappa.Location = new System.Drawing.Point(246, 158);
            this.Potencia_Real_Chappa.Name = "Potencia_Real_Chappa";
            this.Potencia_Real_Chappa.Size = new System.Drawing.Size(0, 13);
            this.Potencia_Real_Chappa.TabIndex = 10;
            // 
            // Potencia_Aparente_Chappa
            // 
            this.Potencia_Aparente_Chappa.AutoSize = true;
            this.Potencia_Aparente_Chappa.Location = new System.Drawing.Point(243, 113);
            this.Potencia_Aparente_Chappa.Name = "Potencia_Aparente_Chappa";
            this.Potencia_Aparente_Chappa.Size = new System.Drawing.Size(0, 13);
            this.Potencia_Aparente_Chappa.TabIndex = 9;
            // 
            // Seccion_Chappa
            // 
            this.Seccion_Chappa.AutoSize = true;
            this.Seccion_Chappa.Location = new System.Drawing.Point(243, 74);
            this.Seccion_Chappa.Name = "Seccion_Chappa";
            this.Seccion_Chappa.Size = new System.Drawing.Size(0, 13);
            this.Seccion_Chappa.TabIndex = 8;
            // 
            // Numero_Chappa
            // 
            this.Numero_Chappa.AutoSize = true;
            this.Numero_Chappa.Location = new System.Drawing.Point(243, 36);
            this.Numero_Chappa.Name = "Numero_Chappa";
            this.Numero_Chappa.Size = new System.Drawing.Size(0, 13);
            this.Numero_Chappa.TabIndex = 7;
            // 
            // Calculo_Potencia_Transformador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Calculo_Potencia_Transformador";
            this.Text = "Calculo_Potencia_Transformador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Calculo_Potencia;
        private System.Windows.Forms.TextBox Ancho_Chappa;
        private System.Windows.Forms.TextBox Largo_Chappa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Potencia_Real_Chappa;
        private System.Windows.Forms.Label Potencia_Aparente_Chappa;
        private System.Windows.Forms.Label Seccion_Chappa;
        private System.Windows.Forms.Label Numero_Chappa;
    }
}