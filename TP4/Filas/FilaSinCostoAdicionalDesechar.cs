using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Interfaz;
using static TP4.ProbabilidadClimaAcum;

namespace TP4.Filas
{
    class FilaSinCostoAdicionalDesechar : Fila
    {
        public FilaSinCostoAdicionalDesechar(int dia, Random random, int cantAComprar, double costoComprarXDocena,  double precioPorDocena): base(dia, random, cantAComprar, costoComprarXDocena, precioPorDocena)
        {
            this.ingresoDiario = this.cantVenta * this.precioPorDocena;
            this.ingresoSobrante = 0;
            this.costoCompra = this.cantAComprar * costoComprarXDocena;
            this.costoFaltante = 0;
            this.gananciaDiariaNeta = this.ingresoDiario + this.ingresoSobrante - this.costoCompra - this.costoFaltante;
        }
    }
}
