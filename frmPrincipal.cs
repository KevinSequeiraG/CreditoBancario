using CreditoBancario.Clases;
using CreditoBancario.Enums;
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
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lstMoneda.Items.AddRange(typeof(Moneda).GetEnumNames());

            cmbPrestamo.DataSource = Enum.GetValues(typeof(TipoPrestamo));

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {

        }

    }
}
