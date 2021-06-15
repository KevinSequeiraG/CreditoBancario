using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Clases
{
    class Avaluo : Gasto
    {
        public override double Monto
        {
            get
            {
                return 100000;
            }
        }
        public override string Nombre
        {
            get
            {
                return "Gastos de Avalúo";
            }
        }
    }
}
