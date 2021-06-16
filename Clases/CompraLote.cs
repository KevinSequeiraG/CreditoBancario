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
        public string Nombre
        {
            get
            {
                return "Compra de lote";
            }
        }
        public int PlazoMeses { get; set; }

        public CompraLote()
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
                    tot = 0.0665f;
                }
                else
                {
                    tot = 0.0365f;
                }
            }
            else if (tipoBanco is BancoNacional)
            {
                if (Moneda is Enums.Moneda.Colones)
                {
                    tot = 0.0735F;
                }
                else
                {
                    tot = 0.0435F;
                }
            }
            else if (tipoBanco is BancoPopular)
            {
                if (Moneda is Enums.Moneda.Colones)
                {
                    tot = 0.0585f;
                }
                else
                {
                    tot = 0.0285f;
                }
            }
            return tot;
        }
    }
}
