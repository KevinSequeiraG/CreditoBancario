using CreditoBancario.Clases;
using CreditoBancario.Enums;
using CreditoBancario.Facades;
using CreditoBancario.Factorys;
using CreditoBancario.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditoBancario
{
    public partial class frmPrincipal : Form
    {
        BancoFactory facBanco;
        PrestamoFactory facPrestamo;
        CotizacionFacade cotizacion;
        Cliente cliente;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //LLenar el List
            //lstMoneda.Items.AddRange(typeof(Moneda).GetEnumNames());
            lstMoneda.Items.Add(Moneda.Colones);
            lstMoneda.Items.Add(Moneda.Dolares);
            //LLenar el ComboBox
            cmbPrestamo.DataSource = Enum.GetValues(typeof(TipoPrestamo));

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
                cotizacion = new CotizacionFacade();

                facBanco = new BancoFactory();
                facPrestamo = new PrestamoFactory();
                cliente = new Cliente();
                cliente.identidicacion = txtIdentificacion.Text;
                cliente.nombre = txtNombre.Text;
                cliente.telefono = mtxTelefono.Text;

                //Paso a paso
                TipoPrestamo tipoPrestamo = (TipoPrestamo)cmbPrestamo.SelectedItem;
                int plazo = (int)nudPlazo.Value;
                decimal monto = Convert.ToDecimal(mtxMonto.Text);
                Moneda moneda = (Moneda)lstMoneda.SelectedItem;
                IPrestamo prestamo = facPrestamo.CrearPrestamo(tipoPrestamo, plazo, monto, moneda, chkSeguroDesempleo.Checked, chkSeguroVida.Checked, chkAvaluo.Checked);
                IBanco banco = facBanco.CrearBanco(rbtBN.Checked, rbtBCR.Checked, rbtBP.Checked, cliente, prestamo);
                cotizacion.InicializarCredito(banco);
                string rutaXml = saveFileDialog.FileName;
                cotizacion.GuardarXml(rutaXml);
                string rutaHtml = Application.StartupPath + "\\" + "cotizacion.html";
                cotizacion.convertToHTML(rutaXml, rutaHtml);
                webBrowser.Url = new Uri(rutaHtml);

            
        }

    }
}
