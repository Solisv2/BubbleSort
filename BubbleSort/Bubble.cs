using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Bubble
    {
        public int [] Sorter (int[] UnsortedArray)
        {
            int Temp;
            for (int i = 0; i <= UnsortedArray.Length - 2; i++)
            {
                for (int j = 0; j <= UnsortedArray.Length - 2; j++)
                {
                    if (UnsortedArray[j] > UnsortedArray[j + 1]) //compares array values and if the lower index is greater,swap the indexes. 
                    {
                        Temp = UnsortedArray[j + 1];
                        UnsortedArray[j + 1] = UnsortedArray[j];
                        UnsortedArray[j] = Temp;
                    }
                }
                double Length = UnsortedArray.Length;       //casts  the ints as doubles to do division for percentage bar
                double val = i;
                double percent = (val/Length)*100;
                if (percent % 10 == 0 && percent !=0)       //prints percentage of sorting in multiples of 10
                {
                    Console.Write($"{percent}% ");
                }
                    
            }
            return UnsortedArray;
        }
    }
}
