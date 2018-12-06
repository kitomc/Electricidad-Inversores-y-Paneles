using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricidad_Inversores_y_Paneles
{
    

    class calculobobina
    {
        //Atributos 

        public Double vp,vs;
        public double potencia_C,
            sn,
            Np,
            Ns,
            Ip,
            Is,
            Num_A_P,
            Num_A_S,
            Lib_A_P,
            Lib_A_S,
            Equi_Pies_Tablap,
            Equi_Pies_Tablas;







        //Constantes
        public double k_US = 37.54;
        public double k_EU = 45;
        public double K = 30;




        //Constructor
        public calculobobina(double vp, Double vs, double potencia_C)
        {
            this.vp = vp;
            this.vs = vs;
            this.potencia_C = potencia_C;
            

        }




        //Metodos

        public void Seccion_nucle( )
        {
            
               sn = Math.Sqrt(potencia_C) ;
               return ;  
            
        }

        public void Numero_espiras_primaria()
        {
            Np = (k_US * vp) / sn;
            Np= Math.Ceiling  (Np);
            return;
        }

        public void Numero_espiras_secundaria()
        {
            Ns = (k_US * vs) / sn;
           Ns = Math.Ceiling  (Ns);

        }


        public void Corriente_primaria()
        {
           Ip = potencia_C / vp;
            
            

        }

        public void Corriente_secundaria()
        {
            Is = potencia_C / vs;
            


        }
        public void Numero_Alambre_Secundario()
        {

            if (Is >= 106.65)
            {
                Num_A_S = 2;
                Equi_Pies_Tablas = 7.7;
            }
            if (Is <= 106.64 & Is >= 84.61)
            {
                Num_A_S = 3;
                Equi_Pies_Tablas = 7.7;
            }
            if (Is <= 84.60 & Is >= 66.29)
            {
                Num_A_S = 4;
                Equi_Pies_Tablas = 7.7;
            }
            if (Is <= 66.28 & Is >= 53.17)
            {
                Num_A_S = 5;
                Equi_Pies_Tablas = 7.7;
            }
            if (Is <= 53.16 & Is >= 42.05)
            {
                Num_A_S = 6;
                Equi_Pies_Tablas = 12.5;

            }
            if (Is <= 42.04 & Is >= 33.39)
            {
                Num_A_S = 7;
                Equi_Pies_Tablas = 12.5;
            }
            if (Is <= 33.38 & Is >= 26.57)
            {
                Num_A_S = 8;
                Equi_Pies_Tablas = 20;
            }
            if (Is <= 26.56 & Is >= 21.21)
            {
                Num_A_S = 9;
                Equi_Pies_Tablas = 25;
            }
            if (Is <= 21.20 & Is >= 16.61)
            {
                Num_A_S = 10;
                Equi_Pies_Tablas = 32;
            }
            if (Is <= 16.60 & Is >= 13.31)
            {
                Num_A_S = 11;
                Equi_Pies_Tablas = 42;
            }
            if (Is <= 13.30 & Is >= 10.51)
            {
                Num_A_S = 12;
                Equi_Pies_Tablas = 50;
            }
            if (Is <= 10.50 & Is >= 8.31)
            {
                Num_A_S = 13;
                Equi_Pies_Tablas = 63;
            }
            if (Is <= 8.30 & Is >= 6.61)
            {
                Num_A_S = 14;
                Equi_Pies_Tablas = 80;
            }
            if (Is <= 6.60 & Is >= 5.21)
            {
                Num_A_S = 15;
                Equi_Pies_Tablas = 100;
            }
            if (Is <= 5.20 & Is >= 4.11)
            {
                Num_A_S = 16;
                Equi_Pies_Tablas = 125;
            }
            if (Is <= 4.10 & Is >= 3.21)
            {
                Num_A_S = 17;
                Equi_Pies_Tablas = 160;
            }
            if (Is <= 3.20 & Is >= 2.61)
            {
                Num_A_S = 18;
                Equi_Pies_Tablas = 200;
            }
            if (Is <= 2.60 & Is >= 2.01)
            {
                Num_A_S = 19;
                Equi_Pies_Tablas = 250;
            }
            if (Is <= 2.00 & Is >= 1.63)
            {
                Num_A_S = 20;
                Equi_Pies_Tablas = 315;
            }
            if (Is <= 1.62 & Is >= 1.29)
            {
                Num_A_S = 21;
                Equi_Pies_Tablas = 400;
            }
            if (Is <= 1.28 & Is >= 1.01)
            {
                Num_A_S = 22;
                Equi_Pies_Tablas = 503;

            }
            if (Is <= 1.00 & Is >= 0.81)
            {
                Num_A_S = 23;
                Equi_Pies_Tablas = 623;
            }
            if (Is <= 0.80 & Is >= 0.65)
            {
                Num_A_S = 24;
                Equi_Pies_Tablas = 800;
            }
            if (Is <= 0.64 & Is >= 0.51)
            {
                Num_A_S = 25;
                Equi_Pies_Tablas = 1000;
            }
            if (Is <= 0.50 & Is >= 0.41)
            {
                Num_A_S = 26;
                Equi_Pies_Tablas = 1260;
            }
            if (Is <= 0.40 & Is >= 0.33)
            {
                Num_A_S = 27;
                Equi_Pies_Tablas = 1580;
            }
            if (Is <= 0.32 & Is >= 0.27)
            {
                Num_A_S = 28;
                Equi_Pies_Tablas = 2000;
            }
            if (Is <= 0.26 & Is >= 0.21)
            {
                Num_A_S = 29;
                Equi_Pies_Tablas = 2250;
            }
            if (Is <= 0.20 & Is >= 0.17)
            {
                Num_A_S = 30;
                Equi_Pies_Tablas = 3160;
            }
            if (Is <= 0.16 & Is >= 0.13)
            {
                Num_A_S = 31;
                Equi_Pies_Tablas = 3993;
            }
            if (Is <= 0.12 & Is >= 0.11)
            {
                Num_A_S = 32;
                Equi_Pies_Tablas = 4868;
            }
            if (Is <= 0.10 & Is >= 0.09)
            {
                Num_A_S = 33;
                Equi_Pies_Tablas = 6160;
            }
            if (Is <= 0.08 & Is >= 0.07)
            {
                Num_A_S = 34;
                Equi_Pies_Tablas = 7821;
            }
            if (Is <= 0.06 & Is >= 0.048)
            {
                Num_A_S = 35;
                Equi_Pies_Tablas = 9876;
            }
            if (Is <= 0.047)
            {
                Num_A_S = 36;
                Equi_Pies_Tablas = 1237;
            }
        }


        public void Numero_Alambre_Primario()
        {

            if (Ip >= 106.65)
            {
                Num_A_P = 2;
                Equi_Pies_Tablap = 7.7;
            }
            if (Ip <= 106.64 & Ip >= 84.61)
            {
                Num_A_P = 3;
                Equi_Pies_Tablap = 7.7;
            }
            if (Ip <= 84.60 & Ip >= 66.29)
            {
                Num_A_P = 4;
                Equi_Pies_Tablap = 7.7;
            }
            if (Ip <= 66.28 & Ip >= 53.17)
            {
                Num_A_P = 5;
                Equi_Pies_Tablap = 7.7;
            }
            if (Ip <= 53.16 & Ip >= 42.05)
            {
                Num_A_P = 6;
                Equi_Pies_Tablap = 12.5;
            }
            if (Ip <= 42.04 & Ip >= 33.39)
            {
                Num_A_P = 7;
                Equi_Pies_Tablap = 12.5;
            }
            if (Ip <= 33.38 & Ip >= 26.57)
            {
                Num_A_P = 8;
                Equi_Pies_Tablap = 20;
            }
            if (Ip <= 26.56 & Ip >= 21.21)
            {
                Num_A_P = 9;
                Equi_Pies_Tablap = 25;
            }
            if (Ip <= 21.20 & Ip >= 16.61)
            {
                Num_A_P = 10;
                Equi_Pies_Tablap = 32;
            }
            if (Ip <= 16.60 & Ip >= 13.31)
            {
                Num_A_P = 11;
                Equi_Pies_Tablap = 42;
            }
            if (Ip <= 13.30 & Ip >= 10.51)
            {
                Num_A_P = 12;
                Equi_Pies_Tablap = 50;
            }
            if (Ip <= 10.50 & Ip >= 8.31)
            {
                Num_A_P = 13;
                Equi_Pies_Tablap = 63;

            }
            if (Ip <= 8.30 & Ip >= 6.61)
            {
                Num_A_P = 14;
                Equi_Pies_Tablap = 80;
            }
            if (Ip <= 6.60 & Ip >= 5.21)
            {
                Num_A_P = 15;
                Equi_Pies_Tablap = 100;
            }
            if (Ip <= 5.20 & Ip >= 4.11)
            {
                Num_A_P = 16;
                Equi_Pies_Tablap = 125;
            }
            if (Ip <= 4.10 & Ip >= 3.21)
            {
                Num_A_P = 17;
                Equi_Pies_Tablap = 160;
            }
            if (Ip <= 3.20 & Ip >= 2.61)
            {
                Num_A_P = 18;
                Equi_Pies_Tablap = 200;
            }
            if (Ip <= 2.60 & Ip >= 2.01)
            {
                Num_A_P = 19;
                Equi_Pies_Tablap = 250;
            }
            if (Ip <= 2.00 & Ip >= 1.63)
            {
                Num_A_P = 20;
                Equi_Pies_Tablap = 315;
            }
            if (Ip <= 1.62 & Ip >= 1.29)
            {
                Num_A_P = 21;
                Equi_Pies_Tablap = 400;
            }
            if (Ip <= 1.28 & Ip >= 1.01)
            {
                Num_A_P = 22;
                Equi_Pies_Tablap = 503;
            }
            if (Ip <= 1.00 & Ip >= 0.81)
            {
                Num_A_P = 23;
                Equi_Pies_Tablap = 623;
            }
            if (Ip <= 0.80 & Ip >= 0.65)
            {
                Num_A_P = 24;
                Equi_Pies_Tablap = 800;
            }
            if (Ip <= 0.64 & Ip >= 0.51)
            {
                Num_A_P = 25;
                Equi_Pies_Tablap = 1000;
            }
            if (Ip <= 0.50 & Ip >= 0.41)
            {
                Num_A_P = 26;
                Equi_Pies_Tablap = 1260;
            }
            if (Ip <= 0.40 & Ip >= 0.33)
            {
                Num_A_P = 27;
                Equi_Pies_Tablap = 1580;
            }
            if (Ip <= 0.32 & Ip >= 0.27)
            {
                Num_A_P = 28;
                Equi_Pies_Tablap = 2000;
            }
            if (Ip <= 0.26 & Ip >= 0.21)
            {
                Num_A_P = 29;
                Equi_Pies_Tablap = 2250;
            }
            if (Ip <= 0.20 & Ip >= 0.17)
            {
                Num_A_P = 30;
                Equi_Pies_Tablap = 3160;
            }
            if (Ip <= 0.16 & Ip >= 0.13)
            {
                Num_A_P = 31;
                Equi_Pies_Tablap = 3993;
            }
            if (Ip <= 0.12 & Ip >= 0.11)
            {
                Num_A_P = 32;
                Equi_Pies_Tablap = 4868;
            }
            if (Ip <= 0.10& Ip >= 0.09)
            {
                Num_A_P = 33;
                Equi_Pies_Tablap = 6160;
            }
            if (Ip <= 0.08 & Ip >= 0.07)
            {
                Num_A_P = 34;
                Equi_Pies_Tablap = 7821;
            }
            if (Ip <= 0.06 & Ip >= 0.048)
            {
                Num_A_P = 35;
                Equi_Pies_Tablap = 9876;
            }
            if (Ip <= 0.047)
            {
                Num_A_P = 36;
                Equi_Pies_Tablap = 1237;

            }
        }


       


        public void Libras_Alambre_Primario()
        {
            double equi_pies;
            
            equi_pies = sn / k_EU;
            Lib_A_P  = ((Np * equi_pies)/Equi_Pies_Tablap);

            

        }
        public void Libras_Alambre_Secundario()
        {
            double equi_pies;

            equi_pies = sn / k_EU;
            Lib_A_S = ((Ns * equi_pies) / Equi_Pies_Tablas);



        }

        //Funciones


    }



    




}
