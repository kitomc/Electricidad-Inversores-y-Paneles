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
    public partial class Calculo_transformador : Form
    {
        public Calculo_transformador()
        {
            InitializeComponent();
        }

        private void btn_CalcularTransformador_Click(object sender, EventArgs e)
        {
            double Pr;
            Double Vp,Vs;

            Pr = Convert.ToDouble(tb_Potencia.Text)*0.8;
            Vp = Convert.ToDouble(tb_Vp.Text);
            Vs = Convert.ToDouble(tb_Vs.Text);

            
            calculobobina bobina1 = new calculobobina( Vp,Vs,Pr);

            bobina1.Corriente_primaria();
            bobina1.Corriente_secundaria();
            bobina1.Seccion_nucle();
            bobina1.Numero_espiras_primaria();
            bobina1.Numero_espiras_secundaria();
            bobina1.Numero_Alambre_Primario();
            bobina1.Numero_Alambre_Secundario();

            lb_NoEspirasPrimaria.Text = bobina1.Np.ToString();
            lb_NoEspirasSecundaria.Text = bobina1.Ns.ToString();
            lb_NoAlambrePrimario.Text = bobina1.Num_A_P.ToString();
            lb_NoAlambreSecundario.Text = bobina1.Num_A_S.ToString();
            lb_PotenciaReal.Text = Pr.ToString();



        }
    }
}
