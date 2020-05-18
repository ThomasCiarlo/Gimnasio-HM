using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendClases
{
    public class Gimnasio
    {

        public List<Alumno> alumnos;

        public Gimnasio()
        {
            this.alumnos = new List<Alumno>();

        }

        public static bool operator ==(Gimnasio g, Alumno a) {

            bool todoOK = false;

            foreach (Alumno b in g.alumnos) 
            {
                if (b.DNI == a.DNI) {
                    todoOK = true;
                }
            }

            return todoOK;
        }

        public static bool operator !=(Gimnasio g, Alumno a) {

            return !(g == a);

        }

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();

            foreach (Alumno a in this.alumnos) {

                texto.AppendLine($"Nombre: {a.Nombre} // Apellido: {a.Apellido} // DNI: {a.DNI}  // Deporte: {a.Deporte}");
            
            }

            return texto.ToString();
        }


    }
}
