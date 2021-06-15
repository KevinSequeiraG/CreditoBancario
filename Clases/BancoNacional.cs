using CreditoBancario.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Clases
{
    class BancoNacional : IBanco
    {
        public Cliente Cliente { get; set; }
        public List<Cuota> Cuotas { get; set; }

        public string Nombre
        {
            get
            {
                return "Banco Nacional";
            }
        }

        public float PorcentajePrima
        {
            get
            {
                return 0.20f;
            }
        }

        public IPrestamo Prestamo { get; set; }

        public void CalcularCuotas()
        {
            double montoFinanciar = (Convert.ToDouble(Prestamo.Monto) * PorcentajePrima) - Convert.ToDouble(Prestamo.Monto);
            double porcentajeImpuesto = 0;
            double porcentajeTotal = 0;
            double resul = 0;
            TBP tbp = new TBP();
            if (Prestamo.Moneda is Enums.Moneda.Colones)
            {
                porcentajeImpuesto = 0.0735;
            }
            else
            {
                porcentajeImpuesto = 0.0435;
            }
            porcentajeTotal = porcentajeImpuesto + tbp.ConsultarMontoActual();
            resul = montoFinanciar * porcentajeTotal;

            for (int i = 0; i < Prestamo.PlazoMeses; i++)
            {
                Cuotas.Add(new Cuota
                {
                    monto = Convert.ToDecimal(resul / 12),
                    interes = Convert.ToSingle(porcentajeTotal),
                    descripcion = "Cuota " + i + " de " + Prestamo.PlazoMeses
                }
            );
            }
        }

        public decimal CalcularIngresoMinimo()
        {
            double tot = double.Parse(Prestamo.Monto.ToString()) / 0.40;
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
