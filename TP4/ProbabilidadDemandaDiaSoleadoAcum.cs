using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TP4
{
    public static class ProbabilidadDemandaDiaSoleadoAcum
    {
        public static double Seis = 0.10;
        public static double Siete = 0.30;
        public static double Ocho = 0.75;
        public static double Nueve = 1;

        public static Int32 GetDemandaDiaSoleado(double probabilidad)
        {
            Debug.Assert(probabilidad >= 0 && probabilidad < 1); 

            if(probabilidad < Seis)
            {
                return 6;
            }
            else if( probabilidad < Siete)
            {
                return 7;
            }
            else if( probabilidad < Ocho)
            {
                return 8;
            }
            return 9;
        }



    }
}
