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

        public BancoNacional()
        {
            Cuotas = new List<Cuota>();
        }
        public void CalcularCuotas()
        {
            TBP tbp = new TBP();
            double montoFinanciar = (Convert.ToDouble(Prestamo.Monto) * PorcentajePrima) - Convert.ToDouble(Prestamo.Monto);
            Type tipobanco = typeof(BancoNacional);
            float porcentajeImpuesto = Prestamo.ObtenerPorcentajeTasaVariable(tipobanco);
            double porcentajeTotal = 0;
            double subTotal = 0;

            string porc = (porcentajeImpuesto + tbp.ConsultarMontoActual()).ToString("N1");
            porcentajeTotal = Convert.ToDouble(porc);
            subTotal = Math.Round((Convert.ToDouble(Prestamo.Monto) - (Convert.ToDouble(Prestamo.Monto) * Convert.ToDouble(PorcentajePrima))) * (porcentajeTotal/100));

            for (int i = 1; i <= Prestamo.PlazoMeses; i++)
            {
                Cuota cuota = new Cuota();
                cuota.descripcion = "Cuota " + i + " de " + Prestamo.PlazoMeses;
                cuota.interes = Convert.ToSingle(porcentajeTotal);
                cuota.monto = Math.Round(Convert.ToDecimal(subTotal/12));
                Cuotas.Add(cuota);
            }
        }

        public decimal CalcularIngresoMinimo()
        {
            decimal tot = Cuotas[1].monto * (100 / 40);

            return tot;
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
