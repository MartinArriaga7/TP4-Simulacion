using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TP4.ProbabilidadClimaAcum;

namespace TP4.Interfaz
{
    interface IFila
    {
        int dia { get; set; }
        double RNDClima { get; }
        climas clima { get; set; }
        double RNDDemanda { get; }
        int demanda { get; set; }
        int cantVenta { get; set; }
        int cantSobrante { get; set; }
        int cantFaltante { get; set; }
        double ingresoDiario { get; set; }
        double ingresoSobrante { get; set; }
        double costoCompra { get; set; }
        double costoFaltante { get; set; }
        double gananciaDiariaNeta { get; set; }
        double acumGanancia { get; set; }

        int cantAComprar { get; set; }
        double precioPorDocena { get; set; }
        string GetClima();

    }
}
