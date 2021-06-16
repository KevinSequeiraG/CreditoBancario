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
            float tot = 0f;
            if (tipoBanco == typeof(BancoCostaRica))
            {
                if (Moneda is Moneda.Colones)
                {
                    tot = 9.45f;
                }
                else
                {
                    tot = 6.45f;
                }
            }
            else if (tipoBanco == typeof(BancoNacional))
            {
                if (Moneda is Moneda.Colones)
                {
                    tot = 8.35f;
                }
                else
                {
                    tot = 5.35F;
                }
            }
            else if (tipoBanco == typeof(BancoPopular))
            {
                if (Moneda is Moneda.Colones)
                {
                    tot = 9.55f;
                }
                else
                {
                    tot = 5.25f;
                }
            }
            return tot;
        }
    }
}
