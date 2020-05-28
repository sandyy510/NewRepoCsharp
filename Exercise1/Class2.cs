using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Exercise1
{
    public class Class2
    {


        public void ejercicio1()


        {
            int[] grades = { 6, 7, 10, 9, 8, 8, 5, 6 };

            int[] grades2 = new int[8];

            for (int i = 0; i < grades.Length; i++)
            {
                grades2[i] = grades[i];
            }

            Console.WriteLine("\nFirst Five Values:\n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("" + grades[i]);
            }

            int smallest = grades[0];
            for (int i = 0; i < 8; i++)

            {
                if (grades[i] <= smallest)
                {
                    smallest = grades[i];

                }
            }

            Console.WriteLine("\nThe smallest number is {0}\n\n", smallest);


            Dictionary<string, int> myDict = new Dictionary<string, int>();

           
            myDict["a"] = 2;
            myDict["b"] = 7;
            myDict["c"] = 5;

         
            foreach (var pair in myDict)
            {
                Console.WriteLine(pair.Key + "\n = " + pair.Value);
            }


            Console.ReadKey();

        }
    }

}

  

 

