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
        public List<Gasto> Gastos { get; set; }
        public Moneda Moneda { get; set; }
        public decimal Monto { get; set; }
        public string Nombre
        {
            get
            {
                return "Compra de vehiculo";
            }
        }
        public int PlazoMeses { get; set; }
        public CompraVehiculo()
        {
            Gastos = new List<Gasto>();
        }
        public float ObtenerPorcentajeTasaVariable(Type tipoBanco)
        {
            throw new NotImplementedException();
        }
    }
}
