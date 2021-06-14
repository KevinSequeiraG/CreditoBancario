using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Clases
{
    class SeguroDesempleo : Gasto
    {
        public override double Monto
        {
            get
            {
                return 90000;
            }
        }
        public override string Nombre
        {
            get
            {
                return "Seguro de desempleo";
            }
        }
    }
}
