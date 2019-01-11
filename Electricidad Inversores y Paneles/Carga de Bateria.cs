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
    public partial class Carga_de_Bateria : Form
    {
        public Carga_de_Bateria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CargaDeBateriaTiempo bateriaTiempo = new CargaDeBateriaTiempo(Convert.ToDouble (tbVoltajeBateria.Text),Convert.ToDouble(  tbAmpereBateria.Text), Convert.ToDouble ( tbVoltajeCargador.Text), Convert.ToDouble( tbAmpereCargador.Text));

            lbWattBateria.Text =  " Watt "+ Convert .ToString(bateriaTiempo.WattBateria);
            lbWattCargador.Text = "Watt " +Convert.ToString(bateriaTiempo.WattCargador);

            string res;
            decimal time;

            time = Convert.ToDecimal( bateriaTiempo._TiempoCarga);
            


            decimal mihora = time;
            TimeSpan tiempo = new TimeSpan(
                            Convert.ToInt32(Math.Floor (mihora)),
                            Convert.ToInt32((mihora - Math.Floor(mihora)) * 60),
                            0);
            lbTiempoCarga.Text = " Su tiempo de carga es de " + string.Format("{0:00} Horas   {1:00} Minutos y  {2:00} segundos ", Math.Floor(tiempo.TotalMinutes / 60), tiempo.TotalMinutes % 60, 0);




        }
    }
}
