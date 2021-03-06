using CreditoBancario.Clases;
using CreditoBancario.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace CreditoBancario.Facades
{
    class CotizacionFacade
    {
        IBanco banco;

        public void GuardarXml(string ruta)
        {

            XmlDocument doc = new XmlDocument();

            doc.LoadXml("<Prestamo></Prestamo>");

            XmlElement root = doc.DocumentElement;

            XmlElement Banco = doc.CreateElement("Banco");
            Banco.SetAttribute("Nombre", banco.Nombre);
            root.AppendChild(Banco);

            XmlElement Informacion = doc.CreateElement("Informacion");
            Informacion.SetAttribute("Tipo", banco.Prestamo.Nombre);
            Informacion.SetAttribute("Plazo", banco.Prestamo.PlazoMeses.ToString());
            Informacion.SetAttribute("Moneda", banco.Prestamo.Moneda.ToString());
            root.AppendChild(Informacion);

            //// Hijos de informacion
            XmlElement nodoMonto = doc.CreateElement("Monto");
            nodoMonto.InnerText = banco.Prestamo.Monto.ToString("0.00");
            Informacion.AppendChild(nodoMonto);

            XmlElement nodoPrima = doc.CreateElement("Prima");
            nodoPrima.InnerText = ((float)banco.Prestamo.Monto * banco.PorcentajePrima).ToString("0.00");
            Informacion.AppendChild(nodoPrima);
            ////

            XmlElement Cliente = doc.CreateElement("Cliente");
            Cliente.SetAttribute("Identificacion", banco.Cliente.identidicacion);
            Cliente.SetAttribute("Nombre", banco.Cliente.nombre);
            Cliente.SetAttribute("Telefono", banco.Cliente.telefono);
            root.AppendChild(Cliente);

            ////Hijos de Cliente
            XmlElement nodoIngresoMinimo = doc.CreateElement("IngresoMinimo");
            nodoIngresoMinimo.InnerText = banco.CalcularIngresoMinimo().ToString("0.00");
            Cliente.AppendChild(nodoIngresoMinimo);
            ////

            XmlElement Gastos = doc.CreateElement("Gastos");
            root.AppendChild(Gastos);

            ////Hijos de Gastos
            foreach (Gasto item in banco.Prestamo.Gastos)
            {
                XmlElement nodoOtrosGastos = doc.CreateElement("OtroGasto");
                nodoOtrosGastos.SetAttribute("Monto", item.Monto.ToString("0.00"));
                nodoOtrosGastos.InnerText = item.Nombre;
                Gastos.AppendChild(nodoOtrosGastos);
            }

            ////
            XmlElement nodoTotalGastos = doc.CreateElement("TotalGastos");
            nodoTotalGastos.InnerText = banco.CalcularOtrosGastos().ToString("0.00");
            root.AppendChild(nodoTotalGastos);

            ////
            XmlElement nodoCuotas = doc.CreateElement("Cuotas");

            foreach (Cuota cuota in banco.Cuotas)
            {
                XmlElement nodoCuota = doc.CreateElement("Cuota");
                nodoCuota.SetAttribute("Monto", cuota.monto.ToString("0.00"));
                nodoCuota.SetAttribute("Interes", cuota.interes.ToString("0.00"));
                nodoCuota.InnerText = cuota.descripcion;
                nodoCuotas.AppendChild(nodoCuota);
            }

            root.AppendChild(nodoCuotas);

            doc.Save(ruta);
        }

        public void InicializarCredito(IBanco banco)
        {
            this.banco = banco;
        }

        public void convertToHTML(string rutaXML, string rutaHtml)
        {
            string rutaXslt = Application.StartupPath + "\\Xslt\\CreditoBancario.xslt";
            // Transformación del XMl utilizando XSLT
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            // Carga en memoria la lectura xslt
            myXslTrans.Load(rutaXslt);
            // Transforma el archivo xml aun archivo HTML
            myXslTrans.Transform(rutaXML, rutaHtml);
        }
    }
}
