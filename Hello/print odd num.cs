using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class odd_number
    {
        public void PrintSumOfOddNumers()
        {
            int sum = 0;
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 4 == 1)
                {
                    sum += arr[i];
                    Console.WriteLine(sum);
                }

            }

            Console.ReadLine();
        }
    }
}
