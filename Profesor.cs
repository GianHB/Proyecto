using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
   public class Profesor:Persona
   {
        public string especialidad;

        public Profesor(string nombre, int edad, string especialidad) : base(nombre, edad)
        {
            this.especialidad = especialidad;
        }
   }
}
