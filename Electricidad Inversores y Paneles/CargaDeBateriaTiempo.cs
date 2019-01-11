using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricidad_Inversores_y_Paneles
{
    class CargaDeBateriaTiempo
    {

       public double _voltajeBateria,_TiempoCarga, _AmpereBateria, _VoltajeCargador,_AmpereCargador,_WattBateria,_WattCargador;

        public CargaDeBateriaTiempo(double voltajeBateria, double AmpereBateria, double VoltajeCargador, double AmpereCargador)
        {
            _voltajeBateria = voltajeBateria;
            _AmpereBateria = AmpereBateria;
            _VoltajeCargador = VoltajeCargador;
            _AmpereCargador = AmpereCargador;
            _WattBateria = VoltajeBateria * AmpereBateria;
            _WattCargador = VoltajeCargador * AmpereCargador;
            _TiempoCarga = WattBateria / WattCargador;
        }

        public double VoltajeBateria { get => _voltajeBateria; set => _voltajeBateria = value; }
        public double AmpereBateria { get => _AmpereBateria; set => _AmpereBateria = value; }
        public double VoltajeCargador { get => _VoltajeCargador; set => _VoltajeCargador = value; }
        public double AmpereCargador { get => _AmpereCargador; set => _AmpereCargador = value; }
        public double WattBateria { get => _WattBateria; set => _WattBateria = value; }
        public double WattCargador { get => _WattCargador; set => _WattCargador = value; }
    }


     
    

   

}
