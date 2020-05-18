using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendClases
{
    public abstract class Cuota
    {
        protected int valor;
        protected string pase;
        protected string deporte;
        protected DateTime diaDePago;

        public int Valor { get { return this.valor; } }
        public string Pase { get { return this.pase; } }
        public string Deporte { get { return this.deporte; } }


        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();

            //texto.AppendFormat($"Valor: {this.Valor}");
            //texto.AppendLine($"PASE: {this.Pase}");
            //texto.AppendLine($"DEPORTE {this.Deporte}");
            texto.AppendLine($"DIA {this.diaDePago.ToString()}");


            return texto.ToString();
        }






    }
}
