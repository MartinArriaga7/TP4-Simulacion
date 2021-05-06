using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TP4
{
    public static class ProbabilidadDemandaDiaNubladoAcum
    {
        public static double Tres = 0.05;
        public static double Cuatro = 0.20;
        public static double Cinco = 0.60;
        public static double Seis = 0.85;
        public static double Siete = 1;

        public static Int32 GetDemandaDiaNublado(double probabilidad)
        {
            Debug.Assert(probabilidad >= 0 && probabilidad < 1);

            if (probabilidad < Tres)
            {
                return 3;
            }
            else if (probabilidad < Cuatro)
            {
                return 4;
            }
            else if (probabilidad < Cinco)
            {
                return 5;
            }
            else if (probabilidad < Seis)
            {
                return 6;
            }
            return 7;
        }


    }
}
