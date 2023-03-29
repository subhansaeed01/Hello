using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    
        public class Math
        {
            public virtual void Dosomething(int a, int b)
            {
                Console.WriteLine("Print Math");
            }


        }
        public class Add : Math
        {

            public override void Dosomething(int a, int b)
            {

                Console.WriteLine("The addition of two number is:" + (a + b));
            }
        }
        public class Sub : Math
        {
            public override void Dosomething(int a, int b)
            {
                Console.WriteLine("Subtraction of two number is:" + (a - b));
            }
        }
    }
