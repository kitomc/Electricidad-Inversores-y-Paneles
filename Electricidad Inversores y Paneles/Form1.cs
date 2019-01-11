using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricidad_Inversores_y_Paneles
{
    public partial class Form1 : Form
    {

        Calculo_Potencia_Transformador ct = new Calculo_Potencia_Transformador ();
        Carga_de_Bateria cb = new Carga_de_Bateria();
        Calculo_Bobina form_calculo_bobina = new Calculo_Bobina();
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculoDePotenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ct.ShowDialog();
        }

        private void cargaDeBateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb.ShowDialog();
        }

        private void calculoDeBobinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_calculo_bobina.ShowDialog();
        }

        private void calculoDeTransformadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculo_transformador frmCalculo_Transformador = new Calculo_transformador();
            frmCalculo_Transformador.ShowDialog();

        }

        private void tiempoDeDuracionDelInversorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiempoDeDuracionInversor tiempoDeDuracionInversor = new TiempoDeDuracionInversor();
            tiempoDeDuracionInversor.ShowDialog();

        }
    }
}
