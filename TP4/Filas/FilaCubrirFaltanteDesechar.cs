using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Filas
{
    class FilaCubrirFaltanteDesechar : Fila
    {
        public FilaCubrirFaltanteDesechar(int dia, Random random, int cantAComprar, double costoComprarXDocena, double precioPorDocena, double costoCubrirFaltante) : base(dia, random, cantAComprar, costoComprarXDocena, precioPorDocena)
        {
        }
    }
}
