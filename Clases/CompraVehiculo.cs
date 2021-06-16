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
            if (tipoBanco is BancoCostaRica)
            {
                if (Moneda is Moneda.Colones)
                {
                    tot = 0.0945f;
                }
                else
                {
                    tot = 0.0645f;
                }
            }
            else if (tipoBanco is BancoNacional)
            {
                if (Moneda is Enums.Moneda.Colones)
                {
                    tot = 0.0835f;
                }
                else
                {
                    tot = 0.0535F;
                }
            }
            else if (tipoBanco is BancoPopular)
            {
                if (Moneda is Enums.Moneda.Colones)
                {
                    tot = 0.0955f;
                }
                else
                {
                    tot = 0.0525f;
                }
            }
            return tot;
        }
    }
}
