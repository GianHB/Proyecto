using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
   public class Persona
   {
        public string nombre;
        public int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public virtual void ExplicarTema(string tema) 
        {
            Console.WriteLine($"{nombre} explica sobre {tema} con dificultad");
        }
   }
}
