using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Clases
{
    abstract class Gasto
    {
        public abstract double Monto { get;}
        public abstract string Nombre { get;}
    }
}
