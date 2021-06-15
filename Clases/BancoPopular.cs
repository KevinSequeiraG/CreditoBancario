using CreditoBancario.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Clases
{
    class BancoPopular : IBanco
    {
        public Cliente Cliente { get; set; }
        public List<Cuota> Cuotas { get; set; }

        public string Nombre
        {
            get
            {
                return "Banco Popular";
            }
        }

        public float PorcentajePrima
        {
            get
            {
                return 0.10f;
            }
        }

        public IPrestamo Prestamo { get; set; }

        public void CalcularCuotas()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularIngresoMinimo()
        {
            double tot = double.Parse(Prestamo.Monto.ToString()) / 0.35;
            return decimal.Parse(tot.ToString());
        }

        public decimal CalcularOtrosGastos()
        {
            decimal tot = 0;
            foreach (var item in Prestamo.Gastos)
            {
                tot += decimal.Parse(item.Monto.ToString());
            }
            return tot;
        }
    }
}
