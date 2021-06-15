using CreditoBancario.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Clases
{
    class BancoCostaRica : IBanco
    {
        public Cliente Cliente { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Cuota> Cuotas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Nombre
        {
            get
            {
                return "Banco Costa Rica";
            }
        }

        public float PorcentajePrima
        {
            get
            {
                return 0.15f;
            }
        }

        public IPrestamo Prestamo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalcularCuotas()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularIngresoMinimo()
        {
            double tot = double.Parse(Prestamo.Monto.ToString()) / 0.375;
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
