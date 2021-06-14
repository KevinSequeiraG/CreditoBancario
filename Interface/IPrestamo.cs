using CreditoBancario.Clases;
using CreditoBancario.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Interface
{
    interface IPrestamo
    {
        List<Gasto> Gastos { get; set; }
        Moneda Moneda { get; set; }
        decimal Monto { get; set; }
        string Nombre { get; set; }
        int PlazoMeses { get; set; }

        float ObtenerPorcentajeTasaVariable(Type tipoBanco);
        
    }
}
