
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
            this.gridRosas = new System.Windows.Forms.DataGridView();
            this.txtPrecioVentaRosa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridRosas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPoliticaCompra
            // 
            this.groupPoliticaCompra.Controls.Add(this.chkDemandaDiaAnterior);
            this.groupPoliticaCompra.Controls.Add(this.label1);
            this.groupPoliticaCompra.Controls.Add(this.txtCantDocenas);
            this.groupPoliticaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPoliticaCompra.Location = new System.Drawing.Point(13, 46);
            this.groupPoliticaCompra.Name = "groupPoliticaCompra";
            this.groupPoliticaCompra.Size = new System.Drawing.Size(492, 44);
            this.groupPoliticaCompra.TabIndex = 1;
            this.groupPoliticaCompra.TabStop = false;
            this.groupPoliticaCompra.Text = "Politica de Compra";
            // 
            // chkDemandaDiaAnterior
            // 
            this.chkDemandaDiaAnterior.AutoSize = true;
            this.chkDemandaDiaAnterior.Location = new System.Drawing.Point(249, 18);
            this.chkDemandaDiaAnterior.Name = "chkDemandaDiaAnterior";
            this.chkDemandaDiaAnterior.Size = new System.Drawing.Size(229, 17);
            this.chkDemandaDiaAnterior.TabIndex = 1;
            this.chkDemandaDiaAnterior.Text = "Comprar igual a la demanda del dia anterior";
            this.chkDemandaDiaAnterior.UseVisualStyleBackColor = true;
            this.chkDemandaDiaAnterior.CheckedChanged += new System.EventHandler(this.OnCheckBoxDemandaChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad a comprar (docenas):";
            // 
            // txtCantDocenas
            // 
            this.txtCantDocenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCantDocenas.Location = new System.Drawing.Point(164, 17);
            this.txtCantDocenas.Name = "txtCantDocenas";
            this.txtCantDocenas.Size = new System.Drawing.Size(79, 20);
            this.txtCantDocenas.TabIndex = 0;
            this.txtCantDocenas.Click += new System.EventHandler(this.OnClickTxtCantidadComprar);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCubrirFaltante);
            this.groupBox1.Controls.Add(this.rdbConCostoAdicional);
            this.groupBox1.Controls.Add(this.rdbSinCostoAdicional);
            this.groupBox1.Location = new System.Drawing.Point(236, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Politica Faltantes";
            // 
            // rdbCubrirFaltante
            // 
            this.rdbCubrirFaltante.AutoSize = true;
            this.rdbCubrirFaltante.Location = new System.Drawing.Point(5, 61);
            this.rdbCubrirFaltante.Name = "rdbCubrirFaltante";
            this.rdbCubrirFaltante.Size = new System.Drawing.Size(90, 17);
            this.rdbCubrirFaltante.TabIndex = 2;
            this.rdbCubrirFaltante.Text = "Cubrir faltante";
            this.rdbCubrirFaltante.UseVisualStyleBackColor = true;
            this.rdbCubrirFaltante.CheckedChanged += new System.EventHandler(this.OnCubrirFaltanteChange);
            // 
            // rdbConCostoAdicional
            // 
            this.rdbConCostoAdicional.AutoSize = true;
            this.rdbConCostoAdicional.Location = new System.Drawing.Point(5, 39);
            this.rdbConCostoAdicional.Name = "rdbConCostoAdicional";
            this.rdbConCostoAdicional.Size = new System.Drawing.Size(118, 17);
            this.rdbConCostoAdicional.TabIndex = 1;
            this.rdbConCostoAdicional.Text = "Con costo adicional";
            this.rdbConCostoAdicional.UseVisualStyleBackColor = true;
            this.rdbConCostoAdicional.CheckedChanged += new System.EventHandler(this.OnConCostoAdicionalChange);
            // 
            // rdbSinCostoAdicional
            // 
            this.rdbSinCostoAdicional.AutoSize = true;
            this.rdbSinCostoAdicional.Checked = true;
            this.rdbSinCostoAdicional.Location = new System.Drawing.Point(5, 17);
            this.rdbSinCostoAdicional.Name = "rdbSinCostoAdicional";
            this.rdbSinCostoAdicional.Size = new System.Drawing.Size(114, 17);
            this.rdbSinCostoAdicional.TabIndex = 0;
            this.rdbSinCostoAdicional.TabStop = true;
            this.rdbSinCostoAdicional.Text = "Sin costo adicional";
            this.rdbSinCostoAdicional.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbVenderCementerio);
            this.groupBox2.Controls.Add(this.rdbDesechar);
            this.groupBox2.Location = new System.Drawing.Point(376, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Politica Sobrantes";
            // 
            // rdbVenderCementerio
            // 
            this.rdbVenderCementerio.AutoSize = true;
            this.rdbVenderCementerio.Location = new System.Drawing.Point(5, 41);
            this.rdbVenderCementerio.Name = "rdbVenderCementerio";
            this.rdbVenderCementerio.Size = new System.Drawing.Size(123, 17);
            this.rdbVenderCementerio.TabIndex = 1;
            this.rdbVenderCementerio.Text = "Vender a cementerio";
            this.rdbVenderCementerio.UseVisualStyleBackColor = true;
            this.rdbVenderCementerio.CheckedChanged += new System.EventHandler(this.OnRdbVenderCementerioChange);
            // 
            // rdbDesechar
            // 
            this.rdbDesechar.AutoSize = true;
            this.rdbDesechar.Checked = true;
            this.rdbDesechar.Location = new System.Drawing.Point(5, 17);
            this.rdbDesechar.Name = "rdbDesechar";
            this.rdbDesechar.Size = new System.Drawing.Size(71, 17);
            this.rdbDesechar.TabIndex = 0;
            this.rdbDesechar.TabStop = true;
            this.rdbDesechar.Text = "Desechar";
            this.rdbDesechar.UseVisualStyleBackColor = true;
            // 
            // lblDesdeDias
            // 
            this.lblDesdeDias.AutoSize = true;
            this.lblDesdeDias.Location = new System.Drawing.Point(539, 87);
            this.lblDesdeDias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesdeDias.Name = "lblDesdeDias";
            this.lblDesdeDias.Size = new System.Drawing.Size(94, 13);
            this.lblDesdeDias.TabIndex = 4;
            this.lblDesdeDias.Text = "Ingrese dia desde:";
            // 
            // txtDiaDesde
            // 
            this.txtDiaDesde.Location = new System.Drawing.Point(641, 87);
            this.txtDiaDesde.Name = "txtDiaDesde";
            this.txtDiaDesde.Size = new System.Drawing.Size(99, 20);
            this.txtDiaDesde.TabIndex = 3;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(542, 144);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(198, 40);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.OnBtnGenerarClick);
            // 
            // txtPrecioCompraDocena
            // 
            this.txtPrecioCompraDocena.Location = new System.Drawing.Point(125, 15);
            this.txtPrecioCompraDocena.Name = "txtPrecioCompraDocena";
            this.txtPrecioCompraDocena.Size = new System.Drawing.Size(73, 20);
            this.txtPrecioCompraDocena.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio compra docena:";
            // 
            // txtDiasAGenerar
            // 
            this.txtDiasAGenerar.Location = new System.Drawing.Point(667, 56);
            this.txtDiasAGenerar.Name = "txtDiasAGenerar";
            this.txtDiasAGenerar.Size = new System.Drawing.Size(73, 20);
            this.txtDiasAGenerar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad dias a generar: ";
            // 
            // gridRosas
            // 
            this.gridRosas.AllowUserToAddRows = false;
            this.gridRosas.AllowUserToDeleteRows = false;
            this.gridRosas.AllowUserToResizeColumns = false;
            this.gridRosas.AllowUserToResizeRows = false;
            this.gridRosas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRosas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.gridRosas.Location = new System.Drawing.Point(13, 210);
            this.gridRosas.Margin = new System.Windows.Forms.Padding(2);
            this.gridRosas.Name = "gridRosas";
            this.gridRosas.RowHeadersVisible = false;
            this.gridRosas.RowHeadersWidth = 51;
            this.gridRosas.RowTemplate.Height = 24;
            this.gridRosas.Size = new System.Drawing.Size(1205, 441);
            this.gridRosas.TabIndex = 11;
            // 
            // txtPrecioVentaRosa
            // 
            this.txtPrecioVentaRosa.Location = new System.Drawing.Point(125, 39);
            this.txtPrecioVentaRosa.Name = "txtPrecioVentaRosa";
            this.txtPrecioVentaRosa.Size = new System.Drawing.Size(73, 20);
            this.txtPrecioVentaRosa.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio venta rosa:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(539, 118);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(99, 13);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "Tiempo en generar:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPrecioCompraDocena);
            this.groupBox3.Controls.Add(this.txtPrecioVentaRosa);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(13, 96);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(218, 88);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Politica Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ejercicio 3 - Rosas";
            // 
            // colDia
            // 
            this.colDia.Frozen = true;
            this.colDia.HeaderText = "Dia";
            this.colDia.MinimumWidth = 6;
            this.colDia.Name = "colDia";
            this.colDia.ReadOnly = true;
            this.colDia.Width = 55;
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
            this.colDemanda.ReadOnly = true;
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
            // 
            // colIngresoSobrante
            // 
            this.colIngresoSobrante.HeaderText = "Ingreso Sobrante";
            this.colIngresoSobrante.MinimumWidth = 6;
            this.colIngresoSobrante.Name = "colIngresoSobrante";
            this.colIngresoSobrante.ReadOnly = true;
            // 
            // colGastoCompra
            // 
            this.colGastoCompra.HeaderText = "Gasto Compra";
            this.colGastoCompra.MinimumWidth = 6;
            this.colGastoCompra.Name = "colGastoCompra";
            this.colGastoCompra.ReadOnly = true;
            this.colGastoCompra.Width = 105;
            // 
            // colGastoFaltante
            // 
            this.colGastoFaltante.HeaderText = "Gasto Faltante";
            this.colGastoFaltante.MinimumWidth = 6;
            this.colGastoFaltante.Name = "colGastoFaltante";
            this.colGastoFaltante.ReadOnly = true;
            this.colGastoFaltante.Width = 105;
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
            this.colGananciaAcum.Width = 155;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1228, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.gridRosas);
            this.Controls.Add(this.txtDiasAGenerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtDiaDesde);
            this.Controls.Add(this.lblDesdeDias);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupPoliticaCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP4 - Simulación (Rosas)";
            this.groupPoliticaCompra.ResumeLayout(false);
            this.groupPoliticaCompra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRosas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView gridRosas;
        private System.Windows.Forms.TextBox txtPrecioVentaRosa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
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

