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
            lstMoneda.Items.AddRange(typeof(Moneda).GetEnumNames());
            //LLenar el ComboBox
            cmbPrestamo.DataSource = Enum.GetValues(typeof(TipoPrestamo));

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            facBanco = new BancoFactory();
            facPrestamo = new PrestamoFactory();
            cliente = new Cliente();
            cliente.identidicacion = txtIdentificacion.Text;
            cliente.nombre = txtNombre.Text;
            cliente.telefono = mtxTelefono.Text;
            cotizacion.InicializarCredito(facBanco.CrearBanco(rbtBN.Checked, rbtBCR.Checked, rbtBP.Checked, cliente, facPrestamo.CrearPrestamo((TipoPrestamo)cmbPrestamo.SelectedItem, Convert.ToInt32(nudPlazo.Value), Convert.ToDecimal(mtxMonto.Text), (Moneda)lstMoneda.SelectedItem, chkSeguroDesempleo.Checked, chkSeguroVida.Checked, chkAvaluo.Checked)));
        }

    }
}
