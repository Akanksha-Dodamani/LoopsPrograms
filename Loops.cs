using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace LoopsProgram
{
    public class Loops
    {
        public static int number = 10;

        public static void LoopMethod()
        {
            // For loop
            Console.WriteLine("Printing for loop: ");
            for (int i = 0; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Do while loop
            Console.WriteLine("Printing do while loop: ");
            int tempNumber = 0;
            do
            {
                Console.Write(tempNumber + " ");
                tempNumber++;
            } while (tempNumber <= 10);
            Console.WriteLine();

            // int Array
            Console.WriteLine("Printing int Array: ");
            int[] integerArray = { 1, 2, 3, 4, 5 };

            foreach (int integer in integerArray)
            {
                Console.Write(integer + " ");
            }
            Console.WriteLine();

            // string Array
            Console.WriteLine("Printing string Array: ");
            string[] stringArray = { "apple", "banana", "watermelon", "orange", "pineapple" };

            foreach (string fruit in stringArray)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();
        }

    }
}
