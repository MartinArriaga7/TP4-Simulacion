﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Filas
{
    class FilaConCostoAdicionalDesechar : Fila
    {
        public FilaConCostoAdicionalDesechar(int dia, Random random, int cantAComprar, double costoComprarXDocena, double precioPorDocena, double costoAdicional) : base(dia, random, cantAComprar, costoComprarXDocena, precioPorDocena)
        {
        }
    }
}
