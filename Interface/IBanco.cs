using CreditoBancario.Clases;
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

        void CalcularCuotas();

        decimal CalcularIngresoMinimo();

        decimal CalcularOtrosGastos();
    }
}
