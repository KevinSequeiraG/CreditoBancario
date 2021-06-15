using CreditoBancario.Enums;
using CreditoBancario.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Clases
{
    class CompraVehiculo : IPrestamo
    {
        public List<Gasto> Gastos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Moneda Moneda { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Monto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PlazoMeses { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public float ObtenerPorcentajeTasaVariable(Type tipoBanco)
        {
            throw new NotImplementedException();
        }
    }
}
