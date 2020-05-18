using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendClases
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private string deporte;
        private string telefono;
        private string dni;
        private string edad;
        private string stringCuota;
        private List<Cuota> cuotas;


        public Alumno(string nombre, string apellido, string deporte,string telefono,string dni,string edad)
        {

            this.nombre = nombre;
            this.apellido = apellido;
            this.deporte = deporte;
            this.telefono = telefono;
            this.dni = dni;
            this.edad = edad;
            this.cuotas = new List<Cuota>();

        }

        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public string Deporte { get { return this.deporte; } }
        public string DNI { get { return this.dni; } }
        public string Edad { get { return this.edad; } }
        public string Telefono { get { return this.telefono; } }
        public string StringCuota {
            
            get { UltimaCuotaMostrar();
                
                return this.stringCuota; }
            set {
                this.stringCuota = value;
            }
        
        }





        public static bool operator ==(Alumno a, string depor)
        {

            bool TodoOk = false;

            if (a.deporte == depor)
            {
                TodoOk = true;
            }

            return TodoOk;

        }

        public static bool operator !=(Alumno a, string depor)
        {

            return !(a == depor);

        }


        public bool AlumnoPago(string dep, int valor, string pase)
        {
            bool todoOk = true;

            try
            {
                switch (dep)
                {
                    case "Boxeo":
                        this.cuotas.Add(Boxeo.Cobrar(valor, pase));
                        break;
                    case "Funcional":
                        this.cuotas.Add(Funcional.Cobrar(valor, pase));
                        break;
                    case "Taekwondo":
                        this.cuotas.Add(Taekwondo.Cobrar(valor, pase));                      
                        break;

                }
            }
            catch (Exception) {
                todoOk = false;
            }


            return todoOk;
        }

        public void UltimaCuotaMostrar() {

            Cuota c;

            c = this.cuotas.Last();

           this.stringCuota = c.ToString();
        
        }







    }
}
