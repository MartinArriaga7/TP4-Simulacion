using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Interfaz;
using static TP4.ProbabilidadClimaAcum;

namespace TP4
{
    public class Fila : IFila
    {
        public int dia { get; set; }
        public double RNDClima { get; }
        public climas clima { get; set; }
        public double RNDDemanda { get; }
        public int demanda { get; set; }
        public int cantVenta { get; set; }
        public int cantSobrante { get; set; }
        public int cantFaltante { get; set; }
        public double ingresoDiario { get; set; }
        public double ingresoSobrante { get; set; }
        public double costoCompra { get; set; }
        public double costoFaltante { get; set; }
        public double gananciaDiariaNeta { get; set; }
        public double acumGanancia { get; set; }


        public int cantAComprar { get; set; }
        public double precioPorDocena { get; set; }
        
        public string GetClima()
        {
            return this.clima == climas.Soleado ? "Soleado" : "Nublado";
        }

        public Fila(int dia, Random random, int cantAComprar, double costoComprarXDocena,  double precioPorDocena)
        {
            this.dia = dia;
            this.cantAComprar = cantAComprar;
            this.precioPorDocena = precioPorDocena;

            RNDClima = Math.Truncate(random.NextDouble() * 100) / 100;
            if (ProbabilidadClimaAcum.GetClima(RNDClima) == ProbabilidadClimaAcum.climas.Soleado) clima = ProbabilidadClimaAcum.climas.Soleado;
            else this.clima = ProbabilidadClimaAcum.climas.Nublado;
            RNDDemanda = Math.Truncate(random.NextDouble() * 100) / 100;
            if (clima == climas.Soleado) demanda = ProbabilidadDemandaDiaSoleadoAcum.GetDemandaDiaSoleado(RNDDemanda);
            else this.demanda = ProbabilidadDemandaDiaNubladoAcum.GetDemandaDiaNublado(RNDDemanda);


            if(cantAComprar >= demanda)
            {
                cantVenta = demanda;
                cantSobrante = cantAComprar - demanda;
                cantFaltante = 0;
            }
            else
            {
                cantVenta = cantAComprar;
                cantSobrante = 0;
                cantFaltante = demanda - cantAComprar;
            }
        }




    }
}
