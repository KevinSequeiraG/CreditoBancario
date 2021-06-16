using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditoBancario.Clases
{
    class TBP
    {
        string ruta = Application.StartupPath + "\\Json\\TBS.json";
        public DateTime fecha { get; set; }
        public float Monto { get; set; }

        public float ConsultarMontoActual()
        {
            using(StreamReader archivo = File.OpenText(ruta))
            {
                string json = archivo.ReadToEnd();

                var arrayJson = JsonConvert.DeserializeObject<List<TBP>>(json);
                
                foreach (var item in arrayJson)
                {
                    fecha = item.fecha;
                    //este if en caso de hacerlo en el 2019
                    /*if (item.fecha == DateTime.Now)
                    {
                        Monto = item.Monto;
                    }*/
                    if (item.Monto == 6.35f)
                    {
                        Monto = item.Monto;
                    }
                    
                }
                return Monto;
            }
        }
    }
}
