
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
            this.groupPoliticaCompra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Location = new System.Drawing.Point(80, 9);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(87, 13);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "TP4 - Simulacion";
            // 
            // groupPoliticaCompra
            // 
            this.groupPoliticaCompra.Controls.Add(this.chkDemandaDiaAnterior);
            this.groupPoliticaCompra.Controls.Add(this.label1);
            this.groupPoliticaCompra.Controls.Add(this.txtCantDocenas);
            this.groupPoliticaCompra.Location = new System.Drawing.Point(10, 33);
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
            this.chkDemandaDiaAnterior.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad a Comprar (docenas):";
            // 
            // txtCantDocenas
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(508, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 88);
            this.groupBox1.TabIndex = 2;
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
            this.groupBox2.Location = new System.Drawing.Point(643, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 88);
            this.groupBox2.TabIndex = 3;
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
            this.lblDesdeDias.Location = new System.Drawing.Point(211, 87);
            this.lblDesdeDias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesdeDias.Name = "lblDesdeDias";
            this.lblDesdeDias.Size = new System.Drawing.Size(102, 13);
            this.lblDesdeDias.TabIndex = 4;
            this.lblDesdeDias.Text = "Ingrese dia DESDE:";
            // 
            // txtDiaDesde
            // 
            this.txtDiaDesde.Location = new System.Drawing.Point(318, 84);
            this.txtDiaDesde.Name = "txtDiaDesde";
            this.txtDiaDesde.Size = new System.Drawing.Size(73, 20);
            this.txtDiaDesde.TabIndex = 5;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(400, 84);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(102, 20);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.OnBtnGenerarClick);
            // 
            // txtPrecioCompraDocena
            // 
            this.txtPrecioCompraDocena.Location = new System.Drawing.Point(133, 83);
            this.txtPrecioCompraDocena.Name = "txtPrecioCompraDocena";
            this.txtPrecioCompraDocena.Size = new System.Drawing.Size(73, 20);
            this.txtPrecioCompraDocena.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio compra docena:";
            // 
            // txtDiasAGenerar
            // 
            this.txtDiasAGenerar.Location = new System.Drawing.Point(426, 13);
            this.txtDiasAGenerar.Name = "txtDiasAGenerar";
            this.txtDiasAGenerar.Size = new System.Drawing.Size(73, 20);
            this.txtDiasAGenerar.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad Dias a Generar: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupPoliticaCompra.ResumeLayout(false);
            this.groupPoliticaCompra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

