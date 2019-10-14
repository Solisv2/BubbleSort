using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Generate
    {
        int Count=5;
        int Min=0;
        int Max=100;

        public Generate()
        {
            //default constructor
        }
        public Generate(int _count, int _min, int _max) //constructor
        {
            Count = _count;
            Min = _min;
            Max = _max;
        }
        public int[] GenerateNum()      //generates int array of psuedo random numbers
        {
            var Rand = new Random();
            int[] RandNumbers = new int[Count];
            for(int i=0;i<Count;i++)
            {
                RandNumbers[i] = Rand.Next(Min,Max);        //limit rand number generation
            }
            return RandNumbers;
        }
       

    }
}
