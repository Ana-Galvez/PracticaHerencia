﻿using System;
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
            Mamiferos humano2 = new Humano("Tatin");
            caballo1.Pensar();
            humano1.Pensar();
            gorila1.Pensar();
            caballo2.Pensar();
            caballo1.Galopar();

            Mamiferos[] nombresMamiferos = new Mamiferos[4];
            nombresMamiferos[0] = caballo1;
            nombresMamiferos[1] = caballo2;
            nombresMamiferos[2] = humano1;
            nombresMamiferos[3] = gorila1;

            foreach (Mamiferos item in nombresMamiferos)
            {
                item.Pensar();
            }

            Secretaria secretaria1 = new Secretaria("Carolina");
            secretaria1.GetNombreEmpleado();
            Empleado secretaria2 = new Secretaria("Lorena");
            secretaria2.GetNombreEmpleado();


        }
    }

    class Empleado
    {
        private String nombreEmpleado;
        public Empleado(String nombreEmpleado)
        {
            this.nombreEmpleado = nombreEmpleado;
        }
        public void GetNombreEmpleado()
        {
            Console.WriteLine("El nombre del empleado es: " + nombreEmpleado);
        }
    }

    class Secretaria : Empleado
    {
        public Secretaria(String nombreSecretaria) : base(nombreSecretaria) { }
        public void hola()
        {
            Console.WriteLine("hola");
        }
    }

    class JefeSeccion : Empleado
    {
        public JefeSeccion(String nombreJefeSeccion) : base(nombreJefeSeccion) { }
    }

    class DirectorGeneral : Empleado
    {
        public DirectorGeneral(String nombreDirectorGeneral) : base(nombreDirectorGeneral) { }
    }

    class Mamiferos
    {
        private String nombreSerVivo;

        public Mamiferos(string nombreSerVivo)
        {
            this.nombreSerVivo = nombreSerVivo;
        }

        protected void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que puedan valerse por sí mismas");
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Soy un mamífero que puede pensar");
        }

        public void GetNombre()
        {
            Console.WriteLine("Mi nombre es " + nombreSerVivo);
        }


    }

    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo) { }
        public void Galopar()
        {
            Console.WriteLine("Puedo galopar");
            Respirar();
        }

        
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano) { }
       new public void Pensar()
        {
            Console.WriteLine("Soy un humano y puedo pensar");
        }
    }

    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila) : base(nombreGorila) { }
        public void Trepar()
        {
            Console.WriteLine("Puedo trepar");
        }

        public override void Pensar()
        {
            Console.WriteLine("Soy un gorila que piensa");
        }
    }
}
