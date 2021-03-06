using CreditoBancario.Clases;
using CreditoBancario.Enums;
using CreditoBancario.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Factorys
{
    class PrestamoFactory
    {
        public IPrestamo CrearPrestamo(TipoPrestamo tipo, int plazo, decimal monto, Moneda moneda, bool desempleo, bool vida, bool avaluo)
        {
            try
            {
                IPrestamo prestamo = null;
                switch (tipo)
                {
                    case TipoPrestamo.Vivienda:
                        prestamo = new CompraVivienda();
                        prestamo.PlazoMeses = plazo;
                        prestamo.Monto = monto;
                        prestamo.Moneda = moneda;
                        if (desempleo)
                        {
                            prestamo.Gastos.Add(new SeguroDesempleo());
                        }
                        if (vida)
                        {
                            prestamo.Gastos.Add(new SeguroVida());
                        }
                        if (avaluo)
                        {
                            prestamo.Gastos.Add(new Avaluo());
                        }
                        break;
                    case TipoPrestamo.Lote:
                        prestamo = new CompraLote();
                        prestamo.PlazoMeses = plazo;
                        prestamo.Monto = monto;
                        prestamo.Moneda = moneda;
                        if (desempleo)
                        {
                            Gasto gasto = new SeguroDesempleo();
                            prestamo.Gastos.Add(gasto);
                        }
                        if (vida)
                        {
                            Gasto gasto = new SeguroVida();
                            prestamo.Gastos.Add(gasto);
                        }
                        if (avaluo)
                        {
                            Gasto gasto = new Avaluo();
                            prestamo.Gastos.Add(gasto);
                        }
                        break;
                    case TipoPrestamo.Vehiculo:
                        prestamo = new CompraVehiculo();
                        prestamo.PlazoMeses = plazo;
                        prestamo.Monto = monto;
                        prestamo.Moneda = moneda;
                        if (desempleo)
                        {
                            prestamo.Gastos.Add(new SeguroDesempleo());
                        }
                        if (vida)
                        {
                            prestamo.Gastos.Add(new SeguroVida());
                        }
                        if (avaluo)
                        {
                            prestamo.Gastos.Add(new Avaluo());
                        }
                        break;
                    default:
                        break;
                }
                return prestamo;

            }
            catch (Exception)
            {
                throw new ApplicationException("Error al crear Prestamo");
            }
        }
    }
}
