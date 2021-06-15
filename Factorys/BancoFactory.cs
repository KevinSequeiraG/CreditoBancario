using CreditoBancario.Clases;
using CreditoBancario.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoBancario.Factorys
{
    class BancoFactory
    {
        public IBanco CrearBanco(bool bn, bool bcr, bool popular, Cliente cliente, IPrestamo prestamo)
        {
            if (bn)
            {
                IBanco banco= new BancoNacional();
                banco.Cliente = cliente;
                banco.Prestamo = prestamo;
                return banco;
            }
            else if (bcr)
            {
                IBanco banco = new BancoCostaRica();
                banco.Cliente = cliente;
                banco.Prestamo = prestamo;
                return banco;
            }
            else if (popular)
            {
                IBanco banco = new BancoPopular();
                banco.Cliente = cliente;
                banco.Prestamo = prestamo;
                return banco;
            }
            else
            {
                return null;
            }
        }
    }
}
