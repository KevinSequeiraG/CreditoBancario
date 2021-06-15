using CreditoBancario.Enums;
using CreditoBancario.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Factorys
{
    class PrestamoFactory
    {
        public IPrestamo CrearPrestamo(TipoPrestamo tipo, int plazo, decimal monto, Moneda moneda, bool desempleo, bool vida, bool avaluo)
        {
            return null;
        }
    }
}
