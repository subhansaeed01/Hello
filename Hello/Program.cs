using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reverse_string obj = new Reverse_string();
            // obj.RevereString();
            // sum obj1 = new sum();
            // dog tommy = new dog();
            // Account myAccount = new Account();
            // myAccount.get_balance(2000);
            // myAccount.show_balance();
            // dynamic polymorphism 
            /* Math obj2;
             obj2= new Math();
               obj2.Dosomething(1,2);
               obj2 = new Add();
               obj2.Dosomething(30,20);
               obj2 = new Sub();
               obj2.Dosomething(30,20);*/
            /* Customer C1 = new Customer();
              C1.PrintFULLName();
              Customer C2 = new Customer("Subhan","Saeed");
              C2.PrintFULLName();*/
            /* table table = new table();
             table.print_table();*/
            Array lead=new Array();
            int [] aray = new int[]{16,17,10,7,9,6,3};
            int n = aray.Length;
            lead.printleader(aray,n);
       
            Console.ReadLine();
        }
    }
}

