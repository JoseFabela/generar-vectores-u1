using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generar_vectores_u1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the vector:");
            int size = int.Parse(Console.ReadLine());

            int[] vector = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vector elements:");
            foreach (int element in vector)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine(); // New line for formatting
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
