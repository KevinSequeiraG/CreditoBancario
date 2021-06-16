using CreditoBancario.Enums;
using CreditoBancario.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Clases
{
    class CompraVivienda : IPrestamo
    {
        public List<Gasto> Gastos { get; set; }
        public Moneda Moneda { get; set; }
        public decimal Monto { get; set; }
        public string Nombre {
            get
            {
                return "Compra de vivienda";
            }
        }
        public int PlazoMeses { get; set; }
        public CompraVivienda()
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
                    tot = 0.0675f;
                }
                else
                {
                    tot = 0.0375f;
                }
            }
            else if (tipoBanco is BancoNacional)
            {
                if (Moneda is Enums.Moneda.Colones)
                {
                    tot = 0.0745F;
                }
                else
                {
                    tot = 0.0445F;
                }
            }
            else if (tipoBanco is BancoPopular)
            {
                if (Moneda is Enums.Moneda.Colones)
                {
                    tot = 0.059f;
                }
                else
                {
                    tot = 0.029f;
                }
            }
            return tot;
        }
    }
}
