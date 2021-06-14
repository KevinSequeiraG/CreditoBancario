using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Interface
{
    interface IBanco
    {
        Cliente Cliente { get; set; }
        List<Cuota> Cuotas { get; set; }
        string Nombre { get; }
        float PorcentajePrima { get; }
        IPrestamo Prestamo { get; set; }

        public void CalcularCuotas()
        {

        }

        public decimal CalcularIngresoMinimo()
        {
            return 0;
        }

        public decimal CalcularOtrosGastos
        {
            return 0;
        }
    }
}
