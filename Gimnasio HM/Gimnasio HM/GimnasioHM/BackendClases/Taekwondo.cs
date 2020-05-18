using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendClases
{
    public class Taekwondo : Cuota
    {
        public Taekwondo(int valor, string pase)
        {

            base.valor = valor;
            base.pase = pase;
            base.deporte = "Taekwondo";
            base.diaDePago = DateTime.Now;

        }

        public static Cuota Cobrar(int valor, string pase)
        {

            Taekwondo tae = new Taekwondo(valor, pase);

            return tae;

        }

    }
}
