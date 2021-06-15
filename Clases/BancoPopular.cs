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
        public Cliente Cliente { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Cuota> Cuotas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Nombre => throw new NotImplementedException();

        public float PorcentajePrima
        {
            get
            {
                return 0.10f;
            }
        }

        public IPrestamo Prestamo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalcularCuotas()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularIngresoMinimo()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularOtrosGastos()
        {
            throw new NotImplementedException();
        }
    }
}
