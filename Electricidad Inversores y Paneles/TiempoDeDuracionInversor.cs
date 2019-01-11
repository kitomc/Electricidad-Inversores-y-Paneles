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
    public partial class TiempoDeDuracionInversor : Form
    {
        public TiempoDeDuracionInversor()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            lbTiempoHora.Visible = true;
            TiempoTrabajoInversor objeto = new TiempoTrabajoInversor(Convert.ToDouble( tbVoltajeAlimentacion.Text),Convert.ToDouble( tbAmperesBaterias.Text),Convert.ToDouble ( tbPotenciaRealConsumo.Text));

            objeto.TH();
     

            //lbTiempoHora.Text = Convert.ToString(objeto._TiempoHora) + " Horas";

           decimal miHora = Convert .ToDecimal( objeto._TiempoHora);

            decimal mihora =  ( miHora);
            TimeSpan tiempo = new TimeSpan(
                            Convert.ToInt32(Math.Floor(mihora)),
                            Convert.ToInt32((mihora - Math.Floor(mihora)) * 60),
                            0);
            lbTiempoHora.Text  = string.Format("{0:00} Horas y {1:00} Minutos", Math.Floor(tiempo.TotalMinutes / 60), tiempo.TotalMinutes % 60, 0);

        }
    }
}
