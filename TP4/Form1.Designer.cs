
namespace TP4_Simulacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitulo = new System.Windows.Forms.Label();
            this.groupPoliticaCompra = new System.Windows.Forms.GroupBox();
            this.chkDemandaDiaAnterior = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantDocenas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCubrirFaltante = new System.Windows.Forms.RadioButton();
            this.rdbConCostoAdicional = new System.Windows.Forms.RadioButton();
            this.rdbSinCostoAdicional = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbVenderCementerio = new System.Windows.Forms.RadioButton();
            this.rdbDesechar = new System.Windows.Forms.RadioButton();
            this.lblDesdeDias = new System.Windows.Forms.Label();
            this.txtDiaDesde = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtPrecioCompraDocena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiasAGenerar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridPeru = new System.Windows.Forms.DataGridView();
            this.txtPrecioVentaRosa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.colDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRNDClima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRNDDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSobrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaltante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngresoDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngresoSobrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGastoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGastoFaltante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGananciaDiaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGananciaAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPoliticaCompra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeru)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Location = new System.Drawing.Point(107, 11);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(115, 17);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "TP4 - Simulacion";
            // 
            // groupPoliticaCompra
            // 
            this.groupPoliticaCompra.Controls.Add(this.chkDemandaDiaAnterior);
            this.groupPoliticaCompra.Controls.Add(this.label1);
            this.groupPoliticaCompra.Controls.Add(this.txtCantDocenas);
            this.groupPoliticaCompra.Location = new System.Drawing.Point(13, 41);
            this.groupPoliticaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.groupPoliticaCompra.Name = "groupPoliticaCompra";
            this.groupPoliticaCompra.Padding = new System.Windows.Forms.Padding(4);
            this.groupPoliticaCompra.Size = new System.Drawing.Size(656, 54);
            this.groupPoliticaCompra.TabIndex = 1;
            this.groupPoliticaCompra.TabStop = false;
            this.groupPoliticaCompra.Text = "Politica de Compra";
            // 
            // chkDemandaDiaAnterior
            // 
            this.chkDemandaDiaAnterior.AutoSize = true;
            this.chkDemandaDiaAnterior.Location = new System.Drawing.Point(332, 22);
            this.chkDemandaDiaAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.chkDemandaDiaAnterior.Name = "chkDemandaDiaAnterior";
            this.chkDemandaDiaAnterior.Size = new System.Drawing.Size(307, 21);
            this.chkDemandaDiaAnterior.TabIndex = 2;
            this.chkDemandaDiaAnterior.Text = "Comprar igual a la demanda del dia anterior";
            this.chkDemandaDiaAnterior.UseVisualStyleBackColor = true;
            this.chkDemandaDiaAnterior.CheckedChanged += new System.EventHandler(this.OnCheckBoxDemandaChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad a Comprar (docenas):";
            // 
            // txtCantDocenas
            // 
            this.txtCantDocenas.Location = new System.Drawing.Point(219, 21);
            this.txtCantDocenas.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantDocenas.Name = "txtCantDocenas";
            this.txtCantDocenas.Size = new System.Drawing.Size(104, 22);
            this.txtCantDocenas.TabIndex = 0;
            this.txtCantDocenas.Click += new System.EventHandler(this.OnClickTxtCantidadComprar);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCubrirFaltante);
            this.groupBox1.Controls.Add(this.rdbConCostoAdicional);
            this.groupBox1.Controls.Add(this.rdbSinCostoAdicional);
            this.groupBox1.Location = new System.Drawing.Point(677, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(172, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Politica Faltantes";
            // 
            // rdbCubrirFaltante
            // 
            this.rdbCubrirFaltante.AutoSize = true;
            this.rdbCubrirFaltante.Location = new System.Drawing.Point(7, 75);
            this.rdbCubrirFaltante.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCubrirFaltante.Name = "rdbCubrirFaltante";
            this.rdbCubrirFaltante.Size = new System.Drawing.Size(118, 21);
            this.rdbCubrirFaltante.TabIndex = 2;
            this.rdbCubrirFaltante.Text = "Cubrir faltante";
            this.rdbCubrirFaltante.UseVisualStyleBackColor = true;
            this.rdbCubrirFaltante.CheckedChanged += new System.EventHandler(this.OnCubrirFaltanteChange);
            // 
            // rdbConCostoAdicional
            // 
            this.rdbConCostoAdicional.AutoSize = true;
            this.rdbConCostoAdicional.Location = new System.Drawing.Point(7, 48);
            this.rdbConCostoAdicional.Margin = new System.Windows.Forms.Padding(4);
            this.rdbConCostoAdicional.Name = "rdbConCostoAdicional";
            this.rdbConCostoAdicional.Size = new System.Drawing.Size(152, 21);
            this.rdbConCostoAdicional.TabIndex = 1;
            this.rdbConCostoAdicional.Text = "Con costo adicional";
            this.rdbConCostoAdicional.UseVisualStyleBackColor = true;
            this.rdbConCostoAdicional.CheckedChanged += new System.EventHandler(this.OnConCostoAdicionalChange);
            // 
            // rdbSinCostoAdicional
            // 
            this.rdbSinCostoAdicional.AutoSize = true;
            this.rdbSinCostoAdicional.Checked = true;
            this.rdbSinCostoAdicional.Location = new System.Drawing.Point(7, 21);
            this.rdbSinCostoAdicional.Margin = new System.Windows.Forms.Padding(4);
            this.rdbSinCostoAdicional.Name = "rdbSinCostoAdicional";
            this.rdbSinCostoAdicional.Size = new System.Drawing.Size(147, 21);
            this.rdbSinCostoAdicional.TabIndex = 0;
            this.rdbSinCostoAdicional.TabStop = true;
            this.rdbSinCostoAdicional.Text = "Sin costo adicional";
            this.rdbSinCostoAdicional.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbVenderCementerio);
            this.groupBox2.Controls.Add(this.rdbDesechar);
            this.groupBox2.Location = new System.Drawing.Point(857, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(172, 108);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Politica Sobrantes";
            // 
            // rdbVenderCementerio
            // 
            this.rdbVenderCementerio.AutoSize = true;
            this.rdbVenderCementerio.Location = new System.Drawing.Point(7, 50);
            this.rdbVenderCementerio.Margin = new System.Windows.Forms.Padding(4);
            this.rdbVenderCementerio.Name = "rdbVenderCementerio";
            this.rdbVenderCementerio.Size = new System.Drawing.Size(161, 21);
            this.rdbVenderCementerio.TabIndex = 1;
            this.rdbVenderCementerio.Text = "Vender a cementerio";
            this.rdbVenderCementerio.UseVisualStyleBackColor = true;
            this.rdbVenderCementerio.CheckedChanged += new System.EventHandler(this.OnRdbVenderCementerioChange);
            // 
            // rdbDesechar
            // 
            this.rdbDesechar.AutoSize = true;
            this.rdbDesechar.Checked = true;
            this.rdbDesechar.Location = new System.Drawing.Point(7, 21);
            this.rdbDesechar.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDesechar.Name = "rdbDesechar";
            this.rdbDesechar.Size = new System.Drawing.Size(90, 21);
            this.rdbDesechar.TabIndex = 0;
            this.rdbDesechar.TabStop = true;
            this.rdbDesechar.Text = "Desechar";
            this.rdbDesechar.UseVisualStyleBackColor = true;
            // 
            // lblDesdeDias
            // 
            this.lblDesdeDias.AutoSize = true;
            this.lblDesdeDias.Location = new System.Drawing.Point(281, 107);
            this.lblDesdeDias.Name = "lblDesdeDias";
            this.lblDesdeDias.Size = new System.Drawing.Size(133, 17);
            this.lblDesdeDias.TabIndex = 4;
            this.lblDesdeDias.Text = "Ingrese dia DESDE:";
            // 
            // txtDiaDesde
            // 
            this.txtDiaDesde.Location = new System.Drawing.Point(424, 103);
            this.txtDiaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaDesde.Name = "txtDiaDesde";
            this.txtDiaDesde.Size = new System.Drawing.Size(96, 22);
            this.txtDiaDesde.TabIndex = 5;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(533, 103);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(136, 25);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.OnBtnGenerarClick);
            // 
            // txtPrecioCompraDocena
            // 
            this.txtPrecioCompraDocena.Location = new System.Drawing.Point(177, 102);
            this.txtPrecioCompraDocena.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioCompraDocena.Name = "txtPrecioCompraDocena";
            this.txtPrecioCompraDocena.Size = new System.Drawing.Size(96, 22);
            this.txtPrecioCompraDocena.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio compra docena:";
            // 
            // txtDiasAGenerar
            // 
            this.txtDiasAGenerar.Location = new System.Drawing.Point(568, 16);
            this.txtDiasAGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiasAGenerar.Name = "txtDiasAGenerar";
            this.txtDiasAGenerar.Size = new System.Drawing.Size(96, 22);
            this.txtDiasAGenerar.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad Dias a Generar: ";
            // 
            // gridPeru
            // 
            this.gridPeru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPeru.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDia,
            this.colRNDClima,
            this.colClima,
            this.colRNDDemanda,
            this.colDemanda,
            this.colCantVenta,
            this.colSobrante,
            this.colFaltante,
            this.colIngresoDiario,
            this.colIngresoSobrante,
            this.colGastoCompra,
            this.colGastoFaltante,
            this.colGananciaDiaria,
            this.colGananciaAcum});
            this.gridPeru.Location = new System.Drawing.Point(18, 205);
            this.gridPeru.Name = "gridPeru";
            this.gridPeru.RowHeadersVisible = false;
            this.gridPeru.RowHeadersWidth = 51;
            this.gridPeru.RowTemplate.Height = 24;
            this.gridPeru.Size = new System.Drawing.Size(1607, 484);
            this.gridPeru.TabIndex = 11;
            // 
            // txtPrecioVentaRosa
            // 
            this.txtPrecioVentaRosa.Location = new System.Drawing.Point(177, 131);
            this.txtPrecioVentaRosa.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVentaRosa.Name = "txtPrecioVentaRosa";
            this.txtPrecioVentaRosa.Size = new System.Drawing.Size(96, 22);
            this.txtPrecioVentaRosa.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio venta rosa:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(1195, 41);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 21);
            this.lblTimer.TabIndex = 14;
            // 
            // colDia
            // 
            this.colDia.Frozen = true;
            this.colDia.HeaderText = "Dia";
            this.colDia.MinimumWidth = 6;
            this.colDia.Name = "colDia";
            this.colDia.ReadOnly = true;
            this.colDia.Width = 50;
            // 
            // colRNDClima
            // 
            this.colRNDClima.HeaderText = "RND Clima";
            this.colRNDClima.MinimumWidth = 6;
            this.colRNDClima.Name = "colRNDClima";
            this.colRNDClima.ReadOnly = true;
            this.colRNDClima.Width = 50;
            // 
            // colClima
            // 
            this.colClima.HeaderText = "Clima";
            this.colClima.MinimumWidth = 6;
            this.colClima.Name = "colClima";
            this.colClima.ReadOnly = true;
            this.colClima.Width = 70;
            // 
            // colRNDDemanda
            // 
            this.colRNDDemanda.HeaderText = "RND Demanda";
            this.colRNDDemanda.MinimumWidth = 6;
            this.colRNDDemanda.Name = "colRNDDemanda";
            this.colRNDDemanda.ReadOnly = true;
            this.colRNDDemanda.Width = 55;
            // 
            // colDemanda
            // 
            this.colDemanda.HeaderText = "Demanda";
            this.colDemanda.MinimumWidth = 6;
            this.colDemanda.Name = "colDemanda";
            this.colDemanda.Width = 70;
            // 
            // colCantVenta
            // 
            this.colCantVenta.HeaderText = "Cant Vendida";
            this.colCantVenta.MinimumWidth = 6;
            this.colCantVenta.Name = "colCantVenta";
            this.colCantVenta.ReadOnly = true;
            this.colCantVenta.Width = 70;
            // 
            // colSobrante
            // 
            this.colSobrante.HeaderText = "Cant Sobrante";
            this.colSobrante.MinimumWidth = 6;
            this.colSobrante.Name = "colSobrante";
            this.colSobrante.ReadOnly = true;
            this.colSobrante.Width = 70;
            // 
            // colFaltante
            // 
            this.colFaltante.HeaderText = "Cant Faltante";
            this.colFaltante.MinimumWidth = 6;
            this.colFaltante.Name = "colFaltante";
            this.colFaltante.ReadOnly = true;
            this.colFaltante.Width = 70;
            // 
            // colIngresoDiario
            // 
            this.colIngresoDiario.HeaderText = "Ingreso Diario";
            this.colIngresoDiario.MinimumWidth = 6;
            this.colIngresoDiario.Name = "colIngresoDiario";
            this.colIngresoDiario.ReadOnly = true;
            this.colIngresoDiario.Width = 125;
            // 
            // colIngresoSobrante
            // 
            this.colIngresoSobrante.HeaderText = "Ingreso Sobrante";
            this.colIngresoSobrante.MinimumWidth = 6;
            this.colIngresoSobrante.Name = "colIngresoSobrante";
            this.colIngresoSobrante.ReadOnly = true;
            this.colIngresoSobrante.Width = 125;
            // 
            // colGastoCompra
            // 
            this.colGastoCompra.HeaderText = "Gasto Compra";
            this.colGastoCompra.MinimumWidth = 6;
            this.colGastoCompra.Name = "colGastoCompra";
            this.colGastoCompra.ReadOnly = true;
            this.colGastoCompra.Width = 125;
            // 
            // colGastoFaltante
            // 
            this.colGastoFaltante.HeaderText = "Gasto Faltante";
            this.colGastoFaltante.MinimumWidth = 6;
            this.colGastoFaltante.Name = "colGastoFaltante";
            this.colGastoFaltante.ReadOnly = true;
            this.colGastoFaltante.Width = 125;
            // 
            // colGananciaDiaria
            // 
            this.colGananciaDiaria.HeaderText = "Ganancia Diaria";
            this.colGananciaDiaria.MinimumWidth = 6;
            this.colGananciaDiaria.Name = "colGananciaDiaria";
            this.colGananciaDiaria.ReadOnly = true;
            this.colGananciaDiaria.Width = 125;
            // 
            // colGananciaAcum
            // 
            this.colGananciaAcum.HeaderText = "Ganancia Acum";
            this.colGananciaAcum.MinimumWidth = 6;
            this.colGananciaAcum.Name = "colGananciaAcum";
            this.colGananciaAcum.ReadOnly = true;
            this.colGananciaAcum.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1979, 814);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.txtPrecioVentaRosa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridPeru);
            this.Controls.Add(this.txtDiasAGenerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioCompraDocena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtDiaDesde);
            this.Controls.Add(this.lblDesdeDias);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupPoliticaCompra);
            this.Controls.Add(this.txtTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupPoliticaCompra.ResumeLayout(false);
            this.groupPoliticaCompra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.GroupBox groupPoliticaCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantDocenas;
        private System.Windows.Forms.CheckBox chkDemandaDiaAnterior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCubrirFaltante;
        private System.Windows.Forms.RadioButton rdbConCostoAdicional;
        private System.Windows.Forms.RadioButton rdbSinCostoAdicional;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbVenderCementerio;
        private System.Windows.Forms.RadioButton rdbDesechar;
        private System.Windows.Forms.Label lblDesdeDias;
        private System.Windows.Forms.TextBox txtDiaDesde;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtPrecioCompraDocena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiasAGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridPeru;
        private System.Windows.Forms.TextBox txtPrecioVentaRosa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRNDClima;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClima;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRNDDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSobrante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaltante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngresoDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngresoSobrante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGastoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGastoFaltante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGananciaDiaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGananciaAcum;
    }
}

