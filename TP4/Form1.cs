using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using TP4_Simulacion;
using TP4;
using static TP4.ProbabilidadClimaAcum;

namespace TP4_Simulacion
{
    public partial class Form1 : Form
    {
        private double costoAdicionalPorUnidad;
        private double costoCubrirFaltantePorDocena;
        private double valorVentaCementerioPorUnidad;
        private int demandaDiaAnterior = -1;

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("DDKWPDOWKADP");
            System.Diagnostics.Debug.WriteLineIf(true, "DAODWDAW");
            
        }

        private void OnCheckBoxDemandaChange(object sender, EventArgs e)
        {
            txtCantDocenas.Enabled = !txtCantDocenas.Enabled;
            chkDemandaDiaAnterior.Enabled = true;
            if(chkDemandaDiaAnterior.Checked)
            {
                string demandaDiaAnterior = Interaction.InputBox("Ingrese la demanda del dia anterior:", "Demanda dia anterior",
                    "8").Replace('.', ',');
                if(!Int32.TryParse(demandaDiaAnterior, out this.demandaDiaAnterior))
                {
                    MessageBox.Show("Error Parametro Invalido (Ingrese un ENTERO)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OnClickTxtCantidadComprar(object sender, EventArgs e)
        {
            txtCantDocenas.Enabled = true;
        }

        private void OnConCostoAdicionalChange(object sender, EventArgs e)
        {
            if(rdbConCostoAdicional.Checked)
            {
                string costo = Interaction.InputBox("Ingrese el costo adicional por rosa:", "Costo Adicional",
                    "0,10").Replace('.',',');
                if(!Double.TryParse(costo, out this.costoAdicionalPorUnidad))
                {
                    MessageBox.Show("Error Parametro Invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rdbSinCostoAdicional.Checked = true;
                }
            }
        }

        private void OnCubrirFaltanteChange(object sender, EventArgs e)
        {
            if(rdbCubrirFaltante.Checked)
            {
                string costoDocenaFaltante = Interaction.InputBox("Ingrese el costo para cubrir faltante por docena:", "Cubrir Faltante",
                    "11").Replace('.', ',');
                if(!Double.TryParse(costoDocenaFaltante, out this.costoCubrirFaltantePorDocena))
                {
                    MessageBox.Show("Error Parametro Invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rdbSinCostoAdicional.Checked = true;
                }
            }
        }

        private void OnRdbVenderCementerioChange(object sender, EventArgs e)
        {
            if(rdbVenderCementerio.Checked)
            {
                string valorVentaCementerio = Interaction.InputBox("Ingrese el valor de venta por rosa al cementerio:", "Vender rosas a cementerio",
                    "0,10").Replace('.', ',');
                if(!Double.TryParse(valorVentaCementerio, out this.valorVentaCementerioPorUnidad))
                {
                    MessageBox.Show("Error Parametro Invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rdbDesechar.Checked = true;
                }
            }
        }

        private void OnBtnGenerarClick(object sender, EventArgs e)
        {
            //code here


            int.TryParse(txtDiasAGenerar.Text, out int cantidadDiasAGenerar);

            int.TryParse(txtCantDocenas.Text, out int cantidadAComprar);

            if(chkDemandaDiaAnterior.Checked)
            {
                cantidadAComprar = demandaDiaAnterior;
            }

            Fila anterior;
            Fila actual;
            for (int dia = 1; dia <= cantidadDiasAGenerar; dia++)
            {
                if(chkDemandaDiaAnterior.Checked)
                {
                   // cantidadAComprar = anterior.demanda;
                }


            }


        }
    }
}
