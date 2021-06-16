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

        public IPrestamo Prestamo { get; set; }

        public BancoCostaRica()
        {
            Cuotas = new List<Cuota>();
        }

        public void CalcularCuotas()
        {
            double montoFinanciar = (Convert.ToDouble(Prestamo.Monto) * PorcentajePrima) - Convert.ToDouble(Prestamo.Monto);
            double porcentajeImpuesto = 0;
            double porcentajeTotal = 0;
            double resul = 0;
            TBP tbp = new TBP();
                        
            porcentajeTotal = porcentajeImpuesto + tbp.ConsultarMontoActual();
            resul = montoFinanciar * porcentajeTotal;

            for (int i = 1; i <= Prestamo.PlazoMeses; i++)
            {
                Cuota cuota = new Cuota();
                cuota.descripcion = "Cuota " + i + " de " + Prestamo.PlazoMeses;
                cuota.interes = Convert.ToSingle(porcentajeTotal);
                cuota.monto = Convert.ToDecimal(resul / 12);
                Cuotas.Add(cuota);
            }
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
