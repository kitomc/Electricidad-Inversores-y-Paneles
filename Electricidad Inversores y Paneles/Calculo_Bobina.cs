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
    public partial class Calculo_Bobina : Form
    {
        public Calculo_Bobina()
        {
            InitializeComponent();
        }
        
        private void Calculo_Bobina_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tbvp,tbvs,tbpotencia;
            

            tbvp = Convert.ToDouble(tb_Vp.Text);
            tbvs = Convert.ToDouble(tb_Vs.Text);
            tbpotencia = Convert.ToDouble(tb_Potencia .Text );
            


            calculobobina bobina = new calculobobina( 
                tbvp,
                tbvs,
                tbpotencia);

           
            // Calculo de la seccion del nucleo
            bobina.Seccion_nucle();
            lb_Sn.Text = bobina.sn.ToString("N2") + " cm Cubico";

            //Calculo de numero de espiras Primarias

            bobina.Numero_espiras_primaria();
            lb_Np.Text = bobina.Np.ToString();

            //Calculo de espiras Secundaria
            bobina.Numero_espiras_secundaria();
            lb_Ns.Text = bobina.Ns.ToString();


            //Corriente Primaria
            bobina.Corriente_primaria();
            lb_Ip.Text = bobina.Ip.ToString("N2");

            //Corriente Secundaria
            bobina.Corriente_secundaria();
            lb_Is.Text = bobina.Is .ToString("N2");

            //Numero de alambre Primario
            bobina.Numero_Alambre_Primario();
            lb_Numero_Alambre_Primario.Text = bobina.Num_A_P.ToString();

            //Numero de alambre Secundario
            bobina.Numero_Alambre_Secundario();
            lb_Numero_Alambre_Secundario.Text = bobina.Num_A_S.ToString();

            //Libras de alambre Primario

            bobina.Libras_Alambre_Primario();
            bobina.Libras_Alambre_Secundario();
            lb_Libras_Np.Text = (((bobina.sn / bobina.K) * bobina.Np) / bobina.Equi_Pies_Tablap).ToString("N2");
            lb_Libras_Ns.Text =  (((bobina.sn / bobina.K)*bobina.Ns)/bobina.Equi_Pies_Tablas).ToString("N2");
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
