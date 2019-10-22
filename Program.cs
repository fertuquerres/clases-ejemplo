using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Persona miPersona = new Persona();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Persona 0");
            miPersona.CalcularMayorEdad();
            Persona miPersona1 = new Persona("Fernando Tuquerres", 22);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Persona 1");
            miPersona1.CalcularMayorEdad();
            Persona miPersona2 = new Persona();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Persona 2");
            Console.WriteLine("Ingrese el nombre de la persona: ");
            miPersona2.SetNombre(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la persona: ");
            miPersona2.SetEdad(Convert.ToInt32(Console.ReadLine()));
            miPersona2.CalcularMayorEdad();
            Console.ReadKey();
        }
    }
}
