using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendClases
{
    public class Funcional : Cuota
    {
        public Funcional(int valor, string pase)
        {

            base.valor = valor;
            base.pase = pase;
            base.deporte = "Funcional";
            base.diaDePago = DateTime.Now;

        }

        public static Cuota Cobrar(int valor, string pase)
        {

            Funcional fun = new Funcional(valor, pase);

            return fun;

        }
    }
}
