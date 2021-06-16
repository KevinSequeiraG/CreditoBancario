namespace CreditoBancario
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.gbOtrosGastos = new System.Windows.Forms.GroupBox();
            this.chkSeguroVida = new System.Windows.Forms.CheckBox();
            this.chkSeguroDesempleo = new System.Windows.Forms.CheckBox();
            this.chkAvaluo = new System.Windows.Forms.CheckBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.gbPrestamo = new System.Windows.Forms.GroupBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.nudPlazo = new System.Windows.Forms.NumericUpDown();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.mtxMonto = new System.Windows.Forms.MaskedTextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lstMoneda = new System.Windows.Forms.ListBox();
            this.cmbPrestamo = new System.Windows.Forms.ComboBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.gbBancos = new System.Windows.Forms.GroupBox();
            this.rbtBP = new System.Windows.Forms.RadioButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.rbtBCR = new System.Windows.Forms.RadioButton();
            this.rbtBN = new System.Windows.Forms.RadioButton();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.gbOtrosGastos.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).BeginInit();
            this.gbBancos.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.gbOtrosGastos);
            this.splitContainerMain.Panel1.Controls.Add(this.gbCliente);
            this.splitContainerMain.Panel1.Controls.Add(this.btnCotizar);
            this.splitContainerMain.Panel1.Controls.Add(this.gbPrestamo);
            this.splitContainerMain.Panel1.Controls.Add(this.gbBancos);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.webBrowser);
            this.splitContainerMain.Size = new System.Drawing.Size(753, 547);
            this.splitContainerMain.SplitterDistance = 330;
            this.splitContainerMain.TabIndex = 2;
            // 
            // gbOtrosGastos
            // 
            this.gbOtrosGastos.Controls.Add(this.chkSeguroVida);
            this.gbOtrosGastos.Controls.Add(this.chkSeguroDesempleo);
            this.gbOtrosGastos.Controls.Add(this.chkAvaluo);
            this.gbOtrosGastos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOtrosGastos.Location = new System.Drawing.Point(12, 386);
            this.gbOtrosGastos.Name = "gbOtrosGastos";
            this.gbOtrosGastos.Size = new System.Drawing.Size(293, 109);
            this.gbOtrosGastos.TabIndex = 10;
            this.gbOtrosGastos.TabStop = false;
            this.gbOtrosGastos.Text = "Otros Gastos";
            // 
            // chkSeguroVida
            // 
            this.chkSeguroVida.AutoSize = true;
            this.chkSeguroVida.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeguroVida.Location = new System.Drawing.Point(23, 77);
            this.chkSeguroVida.Name = "chkSeguroVida";
            this.chkSeguroVida.Size = new System.Drawing.Size(113, 20);
            this.chkSeguroVida.TabIndex = 2;
            this.chkSeguroVida.Text = "Seguro de vida";
            this.chkSeguroVida.UseVisualStyleBackColor = true;
            // 
            // chkSeguroDesempleo
            // 
            this.chkSeguroDesempleo.AutoSize = true;
            this.chkSeguroDesempleo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeguroDesempleo.Location = new System.Drawing.Point(23, 51);
            this.chkSeguroDesempleo.Name = "chkSeguroDesempleo";
            this.chkSeguroDesempleo.Size = new System.Drawing.Size(152, 20);
            this.chkSeguroDesempleo.TabIndex = 1;
            this.chkSeguroDesempleo.Text = "Seguro de desempleo";
            this.chkSeguroDesempleo.UseVisualStyleBackColor = true;
            // 
            // chkAvaluo
            // 
            this.chkAvaluo.AutoSize = true;
            this.chkAvaluo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAvaluo.Location = new System.Drawing.Point(23, 25);
            this.chkAvaluo.Name = "chkAvaluo";
            this.chkAvaluo.Size = new System.Drawing.Size(65, 20);
            this.chkAvaluo.TabIndex = 0;
            this.chkAvaluo.Text = "Avalúo";
            this.chkAvaluo.UseVisualStyleBackColor = true;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtIdentificacion);
            this.gbCliente.Controls.Add(this.lblId);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Controls.Add(this.label9);
            this.gbCliente.Controls.Add(this.mtxTelefono);
            this.gbCliente.Controls.Add(this.label8);
            this.gbCliente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(12, 258);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(293, 122);
            this.gbCliente.TabIndex = 9;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(102, 25);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(169, 23);
            this.txtIdentificacion.TabIndex = 14;
            this.txtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(13, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(83, 16);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Identificación";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(102, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 23);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nombre";
            // 
            // mtxTelefono
            // 
            this.mtxTelefono.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxTelefono.Location = new System.Drawing.Point(101, 87);
            this.mtxTelefono.Mask = "9999-9999";
            this.mtxTelefono.Name = "mtxTelefono";
            this.mtxTelefono.Size = new System.Drawing.Size(170, 23);
            this.mtxTelefono.TabIndex = 9;
            this.mtxTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Teléfono";
            // 
            // btnCotizar
            // 
            this.btnCotizar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.Location = new System.Drawing.Point(115, 501);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(100, 32);
            this.btnCotizar.TabIndex = 2;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // gbPrestamo
            // 
            this.gbPrestamo.Controls.Add(this.lblMeses);
            this.gbPrestamo.Controls.Add(this.nudPlazo);
            this.gbPrestamo.Controls.Add(this.lblPlazo);
            this.gbPrestamo.Controls.Add(this.mtxMonto);
            this.gbPrestamo.Controls.Add(this.lblMonto);
            this.gbPrestamo.Controls.Add(this.lstMoneda);
            this.gbPrestamo.Controls.Add(this.cmbPrestamo);
            this.gbPrestamo.Controls.Add(this.lblMoneda);
            this.gbPrestamo.Controls.Add(this.lblTipo);
            this.gbPrestamo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrestamo.Location = new System.Drawing.Point(12, 78);
            this.gbPrestamo.Name = "gbPrestamo";
            this.gbPrestamo.Size = new System.Drawing.Size(293, 174);
            this.gbPrestamo.TabIndex = 1;
            this.gbPrestamo.TabStop = false;
            this.gbPrestamo.Text = "Préstamo";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeses.Location = new System.Drawing.Point(176, 136);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(45, 16);
            this.lblMeses.TabIndex = 18;
            this.lblMeses.Text = "meses";
            // 
            // nudPlazo
            // 
            this.nudPlazo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPlazo.Location = new System.Drawing.Point(86, 134);
            this.nudPlazo.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudPlazo.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudPlazo.Name = "nudPlazo";
            this.nudPlazo.Size = new System.Drawing.Size(83, 23);
            this.nudPlazo.TabIndex = 17;
            this.nudPlazo.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlazo.Location = new System.Drawing.Point(20, 136);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(38, 16);
            this.lblPlazo.TabIndex = 16;
            this.lblPlazo.Text = "Plazo";
            // 
            // mtxMonto
            // 
            this.mtxMonto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxMonto.Location = new System.Drawing.Point(86, 104);
            this.mtxMonto.Mask = "0000000000";
            this.mtxMonto.Name = "mtxMonto";
            this.mtxMonto.Size = new System.Drawing.Size(185, 23);
            this.mtxMonto.TabIndex = 15;
            this.mtxMonto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(20, 107);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(43, 16);
            this.lblMonto.TabIndex = 14;
            this.lblMonto.Text = "Monto";
            // 
            // lstMoneda
            // 
            this.lstMoneda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMoneda.FormattingEnabled = true;
            this.lstMoneda.ItemHeight = 16;
            this.lstMoneda.Location = new System.Drawing.Point(86, 61);
            this.lstMoneda.Name = "lstMoneda";
            this.lstMoneda.Size = new System.Drawing.Size(185, 36);
            this.lstMoneda.TabIndex = 10;
            // 
            // cmbPrestamo
            // 
            this.cmbPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrestamo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrestamo.FormattingEnabled = true;
            this.cmbPrestamo.Location = new System.Drawing.Point(86, 30);
            this.cmbPrestamo.Name = "cmbPrestamo";
            this.cmbPrestamo.Size = new System.Drawing.Size(186, 24);
            this.cmbPrestamo.TabIndex = 9;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.Location = new System.Drawing.Point(20, 72);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(53, 16);
            this.lblMoneda.TabIndex = 1;
            this.lblMoneda.Text = "Moneda";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(20, 33);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(33, 16);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // gbBancos
            // 
            this.gbBancos.Controls.Add(this.rbtBP);
            this.gbBancos.Controls.Add(this.rbtBCR);
            this.gbBancos.Controls.Add(this.rbtBN);
            this.gbBancos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBancos.Location = new System.Drawing.Point(12, 12);
            this.gbBancos.Name = "gbBancos";
            this.gbBancos.Size = new System.Drawing.Size(293, 60);
            this.gbBancos.TabIndex = 0;
            this.gbBancos.TabStop = false;
            this.gbBancos.Text = "Bancos";
            // 
            // rbtBP
            // 
            this.rbtBP.AutoSize = true;
            this.rbtBP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBP.ImageIndex = 2;
            this.rbtBP.ImageList = this.imageList;
            this.rbtBP.Location = new System.Drawing.Point(207, 18);
            this.rbtBP.Name = "rbtBP";
            this.rbtBP.Size = new System.Drawing.Size(74, 30);
            this.rbtBP.TabIndex = 2;
            this.rbtBP.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "bcr.png");
            this.imageList.Images.SetKeyName(1, "bn.png");
            this.imageList.Images.SetKeyName(2, "popular.png");
            // 
            // rbtBCR
            // 
            this.rbtBCR.AutoSize = true;
            this.rbtBCR.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBCR.ImageIndex = 0;
            this.rbtBCR.ImageList = this.imageList;
            this.rbtBCR.Location = new System.Drawing.Point(109, 18);
            this.rbtBCR.Name = "rbtBCR";
            this.rbtBCR.Size = new System.Drawing.Size(74, 30);
            this.rbtBCR.TabIndex = 1;
            this.rbtBCR.UseVisualStyleBackColor = true;
            // 
            // rbtBN
            // 
            this.rbtBN.AutoSize = true;
            this.rbtBN.Checked = true;
            this.rbtBN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBN.ImageIndex = 1;
            this.rbtBN.ImageList = this.imageList;
            this.rbtBN.Location = new System.Drawing.Point(11, 18);
            this.rbtBN.Name = "rbtBN";
            this.rbtBN.Size = new System.Drawing.Size(74, 30);
            this.rbtBN.TabIndex = 0;
            this.rbtBN.TabStop = true;
            this.rbtBN.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(419, 547);
            this.webBrowser.TabIndex = 0;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Solo XML|*.xml";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 547);
            this.Controls.Add(this.splitContainerMain);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crédito Bancario";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.gbOtrosGastos.ResumeLayout(false);
            this.gbOtrosGastos.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbPrestamo.ResumeLayout(false);
            this.gbPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).EndInit();
            this.gbBancos.ResumeLayout(false);
            this.gbBancos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox gbOtrosGastos;
        private System.Windows.Forms.CheckBox chkSeguroVida;
        private System.Windows.Forms.CheckBox chkSeguroDesempleo;
        private System.Windows.Forms.CheckBox chkAvaluo;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtxTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.GroupBox gbPrestamo;
        private System.Windows.Forms.ListBox lstMoneda;
        private System.Windows.Forms.ComboBox cmbPrestamo;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox gbBancos;
        private System.Windows.Forms.RadioButton rbtBP;
        private System.Windows.Forms.RadioButton rbtBCR;
        private System.Windows.Forms.RadioButton rbtBN;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.MaskedTextBox mtxMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.NumericUpDown nudPlazo;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

