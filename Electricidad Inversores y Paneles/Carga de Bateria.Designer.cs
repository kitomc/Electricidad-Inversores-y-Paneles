﻿namespace Electricidad_Inversores_y_Paneles
{
    partial class Carga_de_Bateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carga_de_Bateria));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWattBateria = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbWattCargador = new System.Windows.Forms.Label();
            this.tbVoltajeBateria = new System.Windows.Forms.TextBox();
            this.tbAmpereBateria = new System.Windows.Forms.TextBox();
            this.tbVoltajeCargador = new System.Windows.Forms.TextBox();
            this.tbAmpereCargador = new System.Windows.Forms.TextBox();
            this.lbTiempoCarga = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voltaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ampere";
            // 
            // lbWattBateria
            // 
            this.lbWattBateria.AutoSize = true;
            this.lbWattBateria.Location = new System.Drawing.Point(89, 100);
            this.lbWattBateria.Name = "lbWattBateria";
            this.lbWattBateria.Size = new System.Drawing.Size(13, 13);
            this.lbWattBateria.TabIndex = 4;
            this.lbWattBateria.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAmpereBateria);
            this.groupBox1.Controls.Add(this.tbVoltajeBateria);
            this.groupBox1.Controls.Add(this.lbWattBateria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(175, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Bateria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbAmpereCargador);
            this.groupBox2.Controls.Add(this.tbVoltajeCargador);
            this.groupBox2.Controls.Add(this.lbWattCargador);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(534, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 135);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cargador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Voltaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ampere";
            // 
            // lbWattCargador
            // 
            this.lbWattCargador.AutoSize = true;
            this.lbWattCargador.Location = new System.Drawing.Point(155, 100);
            this.lbWattCargador.Name = "lbWattCargador";
            this.lbWattCargador.Size = new System.Drawing.Size(13, 13);
            this.lbWattCargador.TabIndex = 2;
            this.lbWattCargador.Text = "0";
            // 
            // tbVoltajeBateria
            // 
            this.tbVoltajeBateria.Location = new System.Drawing.Point(72, 24);
            this.tbVoltajeBateria.Name = "tbVoltajeBateria";
            this.tbVoltajeBateria.Size = new System.Drawing.Size(100, 20);
            this.tbVoltajeBateria.TabIndex = 5;
            // 
            // tbAmpereBateria
            // 
            this.tbAmpereBateria.Location = new System.Drawing.Point(72, 53);
            this.tbAmpereBateria.Name = "tbAmpereBateria";
            this.tbAmpereBateria.Size = new System.Drawing.Size(100, 20);
            this.tbAmpereBateria.TabIndex = 6;
            // 
            // tbVoltajeCargador
            // 
            this.tbVoltajeCargador.Location = new System.Drawing.Point(82, 19);
            this.tbVoltajeCargador.Name = "tbVoltajeCargador";
            this.tbVoltajeCargador.Size = new System.Drawing.Size(100, 20);
            this.tbVoltajeCargador.TabIndex = 3;
            // 
            // tbAmpereCargador
            // 
            this.tbAmpereCargador.Location = new System.Drawing.Point(82, 50);
            this.tbAmpereCargador.Name = "tbAmpereCargador";
            this.tbAmpereCargador.Size = new System.Drawing.Size(100, 20);
            this.tbAmpereCargador.TabIndex = 4;
            // 
            // lbTiempoCarga
            // 
            this.lbTiempoCarga.AutoSize = true;
            this.lbTiempoCarga.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempoCarga.ForeColor = System.Drawing.Color.Red;
            this.lbTiempoCarga.Location = new System.Drawing.Point(21, 211);
            this.lbTiempoCarga.Name = "lbTiempoCarga";
            this.lbTiempoCarga.Size = new System.Drawing.Size(17, 16);
            this.lbTiempoCarga.TabIndex = 7;
            this.lbTiempoCarga.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(606, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Carga_de_Bateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 257);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbTiempoCarga);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Carga_de_Bateria";
            this.Text = "Carga_de_Bateria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbWattBateria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAmpereBateria;
        private System.Windows.Forms.TextBox tbVoltajeBateria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbAmpereCargador;
        private System.Windows.Forms.TextBox tbVoltajeCargador;
        private System.Windows.Forms.Label lbWattCargador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTiempoCarga;
        private System.Windows.Forms.Button button2;
    }
}