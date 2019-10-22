using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseConstructores
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string apellido;
        public Persona()
        {
            nombre = " ";
            edad = 0;
            apellido= " ";
        }
        public Persona(string nnombre, int nedad,string napellido)
        {
            nombre = nnombre;
            edad = nedad;
        }
        public void SetNombre(string nnombre)
        {
            nombre = nnombre;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetEdad(int nedad)
        {
            edad = nedad;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void CalcularMayorEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }
        }
    }
}
