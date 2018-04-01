using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosor
{
    class Planeta
    {
        string nombre;
    }
    class Guerreroz
    {
        string nombre;
        char sexo;
        int ki;
        int universo;
        Boolean estaVivo;
        string cargo;
        Planeta planeta;

        public string Nombre { get; set; }
        public string Raza { get; set; }
        public char Sexo { get; set; }
        public int Ki { get; set; }
        public int Universo { get; set; }
        public bool EstaVivo { get; set; }
        public string Cargo { get; set; }
        public Planeta Planeta { get; set; }

    }
    class Program
    {
        static List<Guerreroz> guerreros = new List<Guerreroz>();
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            { 
            Console.WriteLine("Dragon Ball");
            Console.WriteLine("============");
            Console.WriteLine("1. Agregar Guerreros");
            Console.WriteLine("2. Ver Guerreros");
            Console.WriteLine("0. Salir");           
            opcion = Int32.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    AgregarGuerreros();
                    break;
                case 2:
                    VerGuerreros();
                    break;
            }
        } while (opcion != 0);
         Console.WriteLine("Bye bye cri criminal.");

            Console.ReadKey();
             
        }
    
    static void AgregarGuerreros()
        {
            for  (int i = 0; i < 3; i++)
            {
               Guerreroz guerrero = new Guerreroz();
               Console.WriteLine("Ingrese El Nombre del guerrero: ");
               guerrero.Nombre = Console.ReadLine();
               Console.WriteLine("Ingrese raza del guerrero: ");
                guerrero.Raza = Console.ReadLine();
                guerreros.Add(guerrero);
                
            }
        }
        static void VerGuerreros()
        {
            foreach(Guerreroz guerrero in guerreros)
            {
                ShowGuerrero(guerrero);
            }
        }
        
    
         static  void ShowGuerrero(Guerreroz guerrero) { 
            Console.WriteLine("=========================");
            Console.WriteLine("Guerrero: " + guerrero.Nombre);
            Console.WriteLine("Raza: " + guerrero.Raza);
            Console.WriteLine("=========================");
        }
    }
}
