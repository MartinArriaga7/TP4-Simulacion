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
using TP4.Interfaz;
using TP4.Filas;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace TP4_Simulacion
{
    public partial class Form1 : Form
    {
        private double costoAdicionalPorUnidad = 0;
        private double costoCubrirFaltantePorDocena = 0;
        private double valorVentaCementerioPorUnidad = 0;
        private int demandaDia0 = -1;
        readonly Regex formatoNumericoConDecimales = new Regex(@"^[0-9]+((,){0,1}[0-9]+){0,1}$");
        readonly Regex formatoNumerico = new Regex(@"^[0-9]+$");

        public Form1()
        {
            InitializeComponent();
            this.gridRosas.RowsDefaultCellStyle.BackColor = Color.White;
            this.gridRosas.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
        }

        private void OnCheckBoxDemandaChange(object sender, EventArgs e)
        {
            try
            {
                txtCantDocenas.Enabled = !txtCantDocenas.Enabled;
                chkDemandaDiaAnterior.Enabled = true;
                if (chkDemandaDiaAnterior.Checked)
                {
                    string demandaDiaAnterior = Interaction.InputBox("Ingrese la demanda del dia anterior:", "Demanda dia anterior",
                        "8");
                    if(!formatoNumerico.IsMatch(demandaDiaAnterior))
                    {
                        throw new ArgumentException("El formato no es válido. Formato aceptado: [0-9]");

                    }
                    if (!Int32.TryParse(demandaDiaAnterior, out this.demandaDia0))
                    {
                        throw new ArgumentException("El formato no es válido. Formato aceptado: [0-9]");
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error!", MessageBoxButtons.OK);
            }
         
        }

        private void OnClickTxtCantidadComprar(object sender, EventArgs e)
        {
            txtCantDocenas.Enabled = true;
        }

        private void OnConCostoAdicionalChange(object sender, EventArgs e)
        {
            try
            {
                if (rdbConCostoAdicional.Checked)
                {
                    string costo = Interaction.InputBox("Ingrese el costo adicional por rosa:", "Costo Adicional",
                        "0,10").Replace('.', ',');
                    if (!formatoNumericoConDecimales.IsMatch(costo))
                    {
                        throw new ArgumentException("El formato no es válido. Formato aceptado: [0-9],[0-9]");
                    }

                    if (!Double.TryParse(costo, out this.costoAdicionalPorUnidad))
                    {
                        throw new ArgumentException("El formato no es válido. Formato aceptado: [0-9],[0-9]");
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error!", MessageBoxButtons.OK);
                rdbSinCostoAdicional.Checked = true;
            }
           
        }

        private void OnCubrirFaltanteChange(object sender, EventArgs e)
        {
            try
            {
                if (rdbCubrirFaltante.Checked)
                {
                    string costoDocenaFaltante = Interaction.InputBox("Ingrese el costo para cubrir faltante por docena:", "Cubrir Faltante",
                        "11").Replace('.', ',');
                    if (!formatoNumericoConDecimales.IsMatch(costoDocenaFaltante))
                    {
                        throw new ArgumentException("El formato no es válido. Formato aceptado: [0-9],[0-9]");
                    }

                    if (!Double.TryParse(costoDocenaFaltante, out this.costoCubrirFaltantePorDocena))
                    {
                        throw new ArgumentException("El formato no es válido. Formato aceptado: [0-9],[0-9]");
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error!", MessageBoxButtons.OK);
                rdbSinCostoAdicional.Checked = true;
            }
        }

        private void OnRdbVenderCementerioChange(object sender, EventArgs e)
        {
            try
            {
                if (rdbVenderCementerio.Checked)
                {
                    string valorVentaCementerio = Interaction.InputBox("Ingrese el valor de venta por rosa al cementerio:", "Vender rosas a cementerio",
                        "0,10").Replace('.', ',');
                    if (!formatoNumericoConDecimales.IsMatch(valorVentaCementerio))
                    {
                        throw new ArgumentException("El formato no es válido. Formato aceptado: [0-9],[0-9]");
                    }

                    if (!Double.TryParse(valorVentaCementerio, out this.valorVentaCementerioPorUnidad))
                    {
                        throw new ArgumentException("El formato no es válido. Formato aceptado: [0-9],[0-9]");
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error!", MessageBoxButtons.OK);
                rdbDesechar.Checked = true;
            }
        }

        private void OnBtnGenerarClick(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtDiasAGenerar.Text))
                {
                    throw new ArgumentException("Debes ingresar la cantidad de días a generar");
                }

                if (String.IsNullOrEmpty(txtCantDocenas.Text) && !chkDemandaDiaAnterior.Checked)
                {
                    throw new ArgumentException("Debes ingresar la cantidad de docenas a comprar");
                }

                if (String.IsNullOrEmpty(txtDiaDesde.Text))
                {
                    throw new ArgumentException("Debes ingresar el día desde a mostrar en la tabla");
                }

                if (String.IsNullOrEmpty(txtPrecioCompraDocena.Text))
                {
                    throw new ArgumentException("Debes ingresar el precio de compra por docena");
                }

                if (String.IsNullOrEmpty(txtPrecioVentaRosa.Text))
                {
                    throw new ArgumentException("Debes ingresar el precio de venta de rosa");
                }

                Stopwatch watch = new Stopwatch();
                watch.Start();
                gridRosas.Rows.Clear();
                Random random = new Random();

                int.TryParse(txtDiasAGenerar.Text, out int cantidadDiasAGenerar);
                int.TryParse(txtCantDocenas.Text, out int cantidadAComprar);
                int.TryParse(txtDiaDesde.Text, out int diaDesde);
                double.TryParse(txtPrecioCompraDocena.Text, out double precioCompraDocena);
                double.TryParse(txtPrecioVentaRosa.Text, out double precioPorRosa);
                double precioPorDocena = precioPorRosa * 12;
                double precioCementerio = this.valorVentaCementerioPorUnidad * 12;
                double costoAdicional = this.costoAdicionalPorUnidad * 12;

                if(cantidadDiasAGenerar <= 0)
                {
                    throw new ArgumentException("La cantidad de días a generar debe ser mayor a 0");
                }

                if(diaDesde <= 0)
                {
                    throw new ArgumentException("El dia desde debe ser mayor a 0");
                }
                if(diaDesde > cantidadDiasAGenerar)
                {
                    throw new ArgumentException("No se puede mostrar iteraciones para días que no han sido simulados");
                }
                if(cantidadAComprar <= 0 && !chkDemandaDiaAnterior.Checked)
                {
                    throw new ArgumentException("La cantidad mínima a comprar debe ser mayor a 0");
                }
                if(precioCompraDocena <= 0)
                {
                    throw new ArgumentException("El precio de compra por docena debe ser mayor a 0");
                }
                if(precioPorRosa <= 0)
                {
                    throw new ArgumentException("El precio por rosa debe ser mayor a 0");
                }


                if (chkDemandaDiaAnterior.Checked)
                {
                    cantidadAComprar = demandaDia0;
                }

                IFila anterior = null;
                IFila actual = null;

                for (int dia = 1; dia <= cantidadDiasAGenerar; dia++)
                {

                    if (rdbSinCostoAdicional.Checked && rdbDesechar.Checked)
                    {
                        actual = new FilaSinCostoAdicionalDesechar(dia, random, cantidadAComprar, precioCompraDocena, precioPorDocena);
                    }
                    else if (rdbSinCostoAdicional.Checked && rdbVenderCementerio.Checked)
                    {
                        actual = new FilaSinCostoAdicionalVenderCementerio(dia, random, cantidadAComprar, precioCompraDocena, precioPorDocena, precioCementerio);
                    }
                    else if (rdbConCostoAdicional.Checked && rdbDesechar.Checked)
                    {
                        actual = new FilaConCostoAdicionalDesechar(dia, random, cantidadAComprar, precioCompraDocena, precioPorDocena, costoAdicional);
                    }
                    else if (rdbConCostoAdicional.Checked && rdbVenderCementerio.Checked)
                    {
                        actual = new FilaConCostoAdicionalVenderCementerio(dia, random, cantidadAComprar, precioCompraDocena, precioPorDocena, costoAdicional, precioCementerio);
                    }
                    else if (rdbCubrirFaltante.Checked && rdbDesechar.Checked)
                    {
                        actual = new FilaCubrirFaltanteDesechar(dia, random, cantidadAComprar, precioCompraDocena, precioPorDocena, this.costoCubrirFaltantePorDocena);
                    }
                    else
                    {
                        actual = new FilaCubrirFaltanteVenderCementerio(dia, random, cantidadAComprar, precioCompraDocena, precioPorDocena, this.costoCubrirFaltantePorDocena, precioCementerio);
                    }

                    if (dia == 1)
                    {
                        actual.acumGanancia = actual.gananciaDiariaNeta;
                    }
                    else
                    {
                        actual.acumGanancia += anterior.acumGanancia + actual.gananciaDiariaNeta;
                    }
                    anterior = actual;

                    if ((dia >= diaDesde && dia < diaDesde + 100) || dia == cantidadDiasAGenerar)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        DataGridViewTextBoxCell colDia = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colRNDClima = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colClima = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colRNDDemanda = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colDemanda = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colCantVenta = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colCantSobrante = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colCantFaltante = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colIngresoDiario = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colIngresoSobrante = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colGastoCompra = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colGastoFaltante = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colGananciaDiariaNeta = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colGananciaAcum = new DataGridViewTextBoxCell();

                        colDia.Value = dia;
                        colRNDClima.Value = actual.RNDClima;
                        colClima.Value = actual.GetClima();
                        colRNDDemanda.Value = actual.RNDDemanda;
                        colDemanda.Value = actual.demanda;
                        colCantVenta.Value = actual.cantVenta;
                        colCantSobrante.Value = actual.cantSobrante;
                        colCantFaltante.Value = actual.cantFaltante;
                        colIngresoDiario.Value = actual.ingresoDiario.ToString("F2") + " $";
                        colIngresoSobrante.Value = actual.ingresoSobrante.ToString("F2") + " $";
                        colGastoCompra.Value = actual.costoCompra.ToString("F2") + " $";
                        colGastoFaltante.Value = actual.costoFaltante.ToString("F2") + " $";
                        colGananciaDiariaNeta.Value = actual.gananciaDiariaNeta.ToString("F2") + " $";
                        colGananciaAcum.Value = actual.acumGanancia.ToString("F2") + " $";

                        fila.Cells.Add(colDia);
                        fila.Cells.Add(colRNDClima);
                        fila.Cells.Add(colClima);
                        fila.Cells.Add(colRNDDemanda);
                        fila.Cells.Add(colDemanda);
                        fila.Cells.Add(colCantVenta);
                        fila.Cells.Add(colCantSobrante);
                        fila.Cells.Add(colCantFaltante);
                        fila.Cells.Add(colIngresoDiario);
                        fila.Cells.Add(colIngresoSobrante);
                        fila.Cells.Add(colGastoCompra);
                        fila.Cells.Add(colGastoFaltante);
                        fila.Cells.Add(colGananciaDiariaNeta);
                        fila.Cells.Add(colGananciaAcum);

                        gridRosas.Rows.Add(fila);
                    }

                    if (chkDemandaDiaAnterior.Checked)
                    {
                        cantidadAComprar = actual.demanda;
                    }
                }

                this.gridRosas.Rows[this.gridRosas.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gold;

                watch.Stop();
                lblTimer.Text = String.Format("Tiempo en generar: {0:00}:{1:00}:{2:00}.{3:00}",
                    watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds,
                    watch.Elapsed.Milliseconds / 10);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error!", MessageBoxButtons.OK);
            }
            
        }
    }
}
