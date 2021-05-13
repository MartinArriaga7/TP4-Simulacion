using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public static class ProbabilidadClimaAcum
    {
        public static double SOLEADO = 0.75;
        public static double NUBLADO = 1;
        public enum climas { Soleado, Nublado }
        public static climas GetClima(double probabilidad)
        {
            if(probabilidad < SOLEADO) return climas.Soleado;
            return climas.Nublado;
            
        }
    }
}
