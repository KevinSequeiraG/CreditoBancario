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
            if (tipoBanco == typeof(BancoCostaRica))
            {
                if (Moneda is Moneda.Colones)
                {
                    tot = 6.65f;
                }
                else
                {
                    tot = 3.65f;
                }
            }
            else if (tipoBanco == typeof(BancoNacional))
            {
                if (Moneda is Moneda.Colones)
                {
                    tot = 7.35F;
                }
                else
                {
                    tot = 4.35F;
                }
            }
            else if (tipoBanco == typeof(BancoPopular))
            {
                if (Moneda is Moneda.Colones)
                {
                    tot = 5.85f;
                }
                else
                {
                    tot = 2.85f;
                }
            }
            return tot;
        }
    }
}
