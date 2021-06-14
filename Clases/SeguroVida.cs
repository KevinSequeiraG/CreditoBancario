using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Clases
{
    class SeguroVida : Gasto
    {
        public override double Monto {
            get
            {
                return 50000;
            } 
        }
        public override string Nombre
        {
            get 
            { 
                return "Seguro de vida"; 
            }
        }
    }
}
