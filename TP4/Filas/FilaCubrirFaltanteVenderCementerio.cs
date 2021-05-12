using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Filas
{
    class FilaCubrirFaltanteVenderCementerio : Fila
    {
        public FilaCubrirFaltanteVenderCementerio(int dia, Random random, int cantAComprar, double costoComprarXDocena, double precioPorDocena, double costoCubrirFaltante, double precioCementerio) : base(dia, random, cantAComprar, costoComprarXDocena, precioPorDocena)
        {
            this.ingresoDiario = this.cantVenta * this.precioPorDocena;
            this.costoFaltante = 0;
            if (this.demanda > this.cantVenta)
            {
                int difDemanda = this.demanda - this.cantVenta;
                this.ingresoDiario = this.demanda * this.precioPorDocena;
                this.cantVenta = this.demanda;
                this.costoFaltante = difDemanda * costoCubrirFaltante;
                this.cantFaltante = 0;
            }

            this.ingresoSobrante = this.cantSobrante * precioCementerio;
            this.costoCompra = this.cantAComprar * costoComprarXDocena;

            this.gananciaDiariaNeta = this.ingresoDiario + this.ingresoSobrante - this.costoCompra - this.costoFaltante;
        }
    }
}
