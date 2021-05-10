using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Filas
{
    class FilaSinCostoAdicionalVenderCementerio : Fila
    {
        public FilaSinCostoAdicionalVenderCementerio(int dia, Random random, int cantAComprar, double costoComprarXDocena, double precioPorDocena, double precioCementerio) : base(dia, random, cantAComprar, costoComprarXDocena, precioPorDocena)
        {
            this.ingresoDiario = this.cantVenta * this.precioPorDocena;
            this.ingresoSobrante = this.cantSobrante * precioCementerio;
            this.costoCompra = this.cantAComprar * costoComprarXDocena;
            this.costoFaltante = 0;
            this.gananciaDiariaNeta = this.ingresoDiario + this.ingresoSobrante - this.costoCompra - this.costoFaltante;
        }
    }
}
