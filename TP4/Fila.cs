using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TP4.ProbabilidadClimaAcum;

namespace TP4
{
    public class Fila
    {
        public int dia { get; set; }
        public int demanda { get; set; }
        public int venta { get; set; }
        public int faltante { get; set; }
        public int sobrante { get; set; }
        public double acumGanancia { get; set; }
        public double gananciaDiaria { get; set; }
        public double gananciaSobrante { get; set; }
        public double costoCompra { get; set; }
        public double gananciaDiariaNeta { get; set; }
        public double costoAdicional { get; set; }
        public climas clima { get; set; }

        public int cantAComprar { get; set; }
        public double RNDClima { get; }
        public double RNDDemanda { get; }


        public Fila(int dia, int cantAComprar, double costoComprarXDocena )
        {
            this.dia = dia;
            this.cantAComprar = cantAComprar;
            Random random = new Random();

            RNDClima = Math.Truncate(random.NextDouble() * 100) / 100;
            if (ProbabilidadClimaAcum.GetClima(RNDClima) == ProbabilidadClimaAcum.climas.Soleado) clima = ProbabilidadClimaAcum.climas.Soleado;
            else this.clima = ProbabilidadClimaAcum.climas.Nublado;
            RNDDemanda = Math.Truncate(random.NextDouble() * 100) / 100;
            if (clima == climas.Soleado) demanda = ProbabilidadDemandaDiaSoleadoAcum.GetDemandaDiaSoleado(RNDDemanda);
            else this.demanda = ProbabilidadDemandaDiaNubladoAcum.GetDemandaDiaNublado(RNDDemanda);


            if(cantAComprar >= demanda)
            {
                sobrante = cantAComprar - demanda;
                faltante = 0;
            }
            else
            {
                sobrante = 0;
                faltante = demanda - cantAComprar;
            }
            costoCompra = cantAComprar * costoComprarXDocena;

        }




    }
}
