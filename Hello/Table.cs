using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
   public class table
    {
        public void print_table()
        {
            int j, n;
            Console.WriteLine("Write any number to print the Table");
            n= Convert.ToInt32(Console.ReadLine());
            for(j=1; j<=10; j++)
            {
                Console.WriteLine("{0}*{1}={2}",n,j,n*j);
            }
        }
    }
}
