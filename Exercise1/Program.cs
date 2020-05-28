using System;
using System.Linq;

namespace Exercise1
{
    public class Class1
    {
        static void Main(string[] args)
        {

            string cadena1 = "hola";
            string cadena2 = "Hola";

            if (cadena1.CompareTo(cadena2) == 0)
                Console.WriteLine($"Both strings have same value.");
            else
                Console.WriteLine($"{cadena1} and {cadena2} are different.\n");


            int[] numeros = { 10, 52, 5, 6, 69, 80, 23, 91 };

            Console.WriteLine(numeros.Max());


            string[] nombres = { "Jonathan", "Erick", "Susy", "Ana", "Pedro", "Veronica", "Lucas", "Karla", "Marcos", "Yanira", "Zuleima" };

            int length = nombres.Length;

            Array.Sort(nombres);

            Console.WriteLine("\nArray ordenado:\n");

            for (int i = 0; i < length; i++)
            
                Console.WriteLine(nombres[i]);
            

            string name = "Sandy";
            int nameLength = name.Length;
            
                Console.WriteLine("\nThe name " + name + " contains " + nameLength + " letters.");
            


            Class2 ejercicio = new Class2();

            ejercicio.ejercicio1();
        

        }
    }

}

