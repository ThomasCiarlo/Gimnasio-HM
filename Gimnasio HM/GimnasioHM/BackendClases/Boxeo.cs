using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendClases
{
    public class Boxeo : Cuota
    {

        public Boxeo(int valor, string pase) {

            base.valor = valor;
            base.pase = pase;
            base.deporte = "Boxeo";
            base.diaDePago = DateTime.Now;
        
        }

        public static Cuota Cobrar(int valor, string pase)
        {

             Boxeo box = new Boxeo(valor, pase);

            return box;
        }
      


    }
}
