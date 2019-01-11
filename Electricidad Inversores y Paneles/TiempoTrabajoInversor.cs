using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricidad_Inversores_y_Paneles
{
    class TiempoTrabajoInversor
    {

        public double _VoltajeAlimentacionInversor = 0; //Voltaje de alimentacion del inversor
        public double _AmpereBaterias = 0; //Amperes de baterias de inversor
        public double _rendimientoDeTrabajo = 0.8; //80% de su capacidad
        public double _potenciaRealDeConsumo = 0; //Potencia real de consumo
        public double _TiempoHora = 0;

        public TiempoTrabajoInversor(double VoltajeAlimentacionInversor, double AmpereBaterias, double potenciaRealDeConsumo)
        {
            _VoltajeAlimentacionInversor = VoltajeAlimentacionInversor;
            _AmpereBaterias = AmpereBaterias;
            _potenciaRealDeConsumo = potenciaRealDeConsumo;
        }

        public double VoltajeAlimentacionInversor { get;set;}
        public double AmpereBaterias { get; set; }
        public double potenciaRealDeConsumo { get; set; }
        

        public void TH()
        {


            _TiempoHora = (((_VoltajeAlimentacionInversor * _AmpereBaterias) * _rendimientoDeTrabajo) / _potenciaRealDeConsumo);
            return;

        }



    }
}
