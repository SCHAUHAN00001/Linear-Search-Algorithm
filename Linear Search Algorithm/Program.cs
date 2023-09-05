using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Linear_Search(A, 9, 5));
            Console.ReadLine();
        }
        public static int Linear_Search(int[] Array, int N , int Key)
        {
            int index = 0;
            while(index < N)
            {
                if (Array[index] == Key)
                {
                    return index;
                }
                index = index + 1;
            }
            return -1;
        }
    }
}
