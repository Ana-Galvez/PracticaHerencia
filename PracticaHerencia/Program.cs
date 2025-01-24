using System;
using System.Runtime.InteropServices;

namespace PracticaHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo caballo1 = new Caballo("Bucéfalo");
            Caballo caballo2 = new Caballo("Génitor");
            Humano humano1 = new Humano("Ana");
            Gorila gorila1 = new Gorila("Koko");
            caballo2.GetNombre();
           
        }
    }

    class Mamiferos
    {
        private String nombreSerVivo;

        public Mamiferos(string nombreSerVivo)
        {
            this.nombreSerVivo = nombreSerVivo;
        }

        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que puedan valerse por sí mismas");
        }

        public void GetNombre()
        {
            Console.WriteLine("Mi nombre es " + nombreSerVivo);
        }


    }

    class Caballo: Mamiferos 
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo) { }
        public void Galopar()
        {
            Console.WriteLine("Puedo galopar");
        }
    }

    class Humano : Mamiferos 
    {
        public Humano(String nombreHumano) : base(nombreHumano) { }
        public void Pensar()
        {
            Console.WriteLine("Puedo pensar");
        }
    }

    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila):base(nombreGorila) { }
        public void Trepar()
        {
            Console.WriteLine("Puedo trepar");
        }
    }
}
