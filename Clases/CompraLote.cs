using CreditoBancario.Enums;
using CreditoBancario.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Clases
{
    class CompraLote : IPrestamo
    {
        public List<Gasto> Gastos { get; set; }
        public Moneda Moneda { get; set; }
        public decimal Monto { get; set; }
        public string Nombre { get; set; }
        public int PlazoMeses { get; set; }

        public CompraLote()
        {
            Gastos = new List<Gasto>();
        }
        public float ObtenerPorcentajeTasaVariable(Type tipoBanco)
        {
            throw new NotImplementedException();
        }
    }
}
