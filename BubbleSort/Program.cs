using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 50000;  //number of random numbers
            int Min = 0;        // min and max of numbers to be generated
            int Max = 1000;
            int LineLength = 20;
            Generate generator = new Generate(Count,Min,Max);      
            Bubble Mysorter = new Bubble(); 
            int[] Unsorted = generator.GenerateNum();   //generates random array

            for (int i = 0; i < Unsorted.Length; i++)       //prints all unsorted array values
            {
                if (i % LineLength == 0 && i!=0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{Unsorted[i]} ");
            }
            Console.WriteLine();
            int[] Sorted = Mysorter.Sorter(Unsorted);  //sort the array
            Console.WriteLine();

            for (int i = 0; i < Unsorted.Length; i++)   //prints sorted array
            {
                if (i % LineLength == 0 && i != 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{Sorted[i]} "); 
            }
            Console.WriteLine();
        }
    }
}
