﻿using CreditoBancario.Interface;
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
            float porcentajeImpuesto = Prestamo.ObtenerPorcentajeTasaVariable(this);
            double porcentajeTotal = 0;
            double resul = 0;

            
            
            porcentajeTotal = porcentajeImpuesto + tbp.ConsultarMontoActual();
            resul = montoFinanciar * porcentajeTotal;
            Console.WriteLine("PORCENTAJE TOTAAAAL" + porcentajeTotal);
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
