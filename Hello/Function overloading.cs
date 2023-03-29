using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class sum
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public void convert_double_to_int()
        {
            double val = 21.34;
            int m = Convert.ToInt32(val);
            Console.WriteLine("Converted double {0} to integer {1} ", val, m);
        }
    }
}
