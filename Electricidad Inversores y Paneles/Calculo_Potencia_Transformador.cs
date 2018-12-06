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
    public partial class Calculo_Potencia_Transformador : Form
    {
        public Calculo_Potencia_Transformador()
        {
            InitializeComponent();
        }
        double centro,seccion;
        double N_Chappa;



        private void btn_Calculo_Potencia_Click(object sender, EventArgs e)
        {

            //Calculo del centro
            
            centro = (Convert.ToDouble (Largo_Chappa.Text )/3) ;
            

            if (centro <= 4 )
            {
                N_Chappa = 4;
            }

            if (centro > 4 & centro < 5)
            {
                N_Chappa = 4.5;
            }

            if (centro >5 & centro < 6 )
            {
                N_Chappa = 5;
            }

            if (centro ==6)
            {
                N_Chappa = 6;
            }

            if (centro > 6 & centro < 7)
            {
                N_Chappa = 6.4;
            }

            Numero_Chappa.Text = N_Chappa.ToString();

            //Caluclo de la seccion del nucleo
            
           seccion =  Convert.ToDouble (  Ancho_Chappa.Text) * N_Chappa ;



            Seccion_Chappa.Text = seccion.ToString() + " cm cuadrado" ;


            //Calculo de potencia aparente

            double potencia_aparente;

            potencia_aparente = seccion * seccion;
            Potencia_Aparente_Chappa.Text = potencia_aparente.ToString() + " Watts";


            //Calculo Potencia Real

            double potencia_real;
            potencia_real  = potencia_aparente * 0.8;
            Potencia_Real_Chappa.Text = potencia_real.ToString() + " Watts";
        }
    }
}
