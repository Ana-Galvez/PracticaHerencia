using System;
using System.Runtime.InteropServices;

namespace PracticaHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Mamiferos
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que puedan valerse por sí mismas");
        }
    }

    class Caballo: Mamiferos 
    {
        public void Galopar()
        {
            Console.WriteLine("Puedo galopar");
        }
    }

    class Humano : Mamiferos 
    {
        public void Pensar()
        {
            Console.WriteLine("Puedo pensar");
        }
    }

    class Gorila : Mamiferos
    {
        public void Trepar()
        {
            Console.WriteLine("Puedo trepar");
        }
    }
}
