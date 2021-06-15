using CreditoBancario.Clases;
using CreditoBancario.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CreditoBancario.Facades
{
    class CotizacionFacade
    {
        IBanco banco;

        public void GuardarXml(string ruta)
        {
            
            XmlDocument doc = new XmlDocument();

            if (File.Exists(ruta) == false)
            {
                doc.LoadXml("<Prestamo></Prestamo>");
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
                doc.AppendChild(dec);

                string rutaXslt = System.Windows.Forms.Application.StartupPath + "\\Xslt\\CreditoBancario.xslt";
                XmlProcessingInstruction xslt = doc.CreateProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" href=\"" + rutaXslt + "\"");
                doc.AppendChild(xslt);
            }
            else
            {
                doc.Load(ruta);
            }

            XmlElement root = doc.DocumentElement;

            XmlElement Banco = doc.CreateElement("Banco");
            Banco.SetAttribute("Nombre", banco.Nombre);
            root.AppendChild(Banco);

            XmlElement Informacion = doc.CreateElement("Informacion");
            Informacion.SetAttribute("Tipo", banco.GetType().ToString());
            Informacion.SetAttribute("Plazo", banco.Prestamo.PlazoMeses.ToString());
            Informacion.SetAttribute("Moneda", banco.Prestamo.Moneda.ToString());
            root.AppendChild(Informacion);
            
            //// Hijos de informacion
            XmlElement nodoMonto = doc.CreateElement("Monto");
            nodoMonto.InnerText = banco.Prestamo.Monto.ToString();
            Informacion.AppendChild(nodoMonto);

            XmlElement nodoPrima = doc.CreateElement("Prima");
            // duda de prima
            nodoPrima.InnerText = banco.PorcentajePrima.ToString();
            Informacion.AppendChild(nodoPrima);
            ////

            XmlElement Cliente = doc.CreateElement("Cliente");
            Informacion.SetAttribute("Identificacion", banco.Cliente.identidicacion);
            Informacion.SetAttribute("Nombre", banco.Cliente.nombre);
            Informacion.SetAttribute("Telefono", banco.Cliente.telefono);
            root.AppendChild(Cliente);

            ////Hijos de Cliente
            XmlElement nodoIngresoMinimo = doc.CreateElement("IngresoMinimo");
            nodoIngresoMinimo.InnerText = banco.CalcularIngresoMinimo().ToString();
            Cliente.AppendChild(nodoIngresoMinimo);
            ////

            XmlElement Gastos = doc.CreateElement("Gastos");
            root.AppendChild(Gastos);

            ////Hijos de Gastos
            foreach (Gasto item in banco.Prestamo.Gastos)
            {
                XmlElement nodoOtrosGastos = doc.CreateElement("OtroGasto");
                nodoOtrosGastos.SetAttribute("Monto", item.Monto.ToString());
                if (item is SeguroVida)
                {
                    nodoOtrosGastos.InnerText = banco.Prestamo.Gastos.ToString();
                }
                else if (item is SeguroDesempleo)
                {

                }else if(item is Avaluo)
                {

                }
                
            }
            ////


        }

        public void InicializarCredito(IBanco banco)
        {
            this.banco = banco;
        }
    }
}
