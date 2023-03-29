using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class Reverse_string
    {
        
        public void RevereString()
        {

            string rev = "Subhan Saeed";
            int i;
            for (i = rev.Length - 1; i >= 0; i--)
            {
                Console.Write(rev[i]);
            }

            Console.ReadLine();
        }
        
    }
   
    public class animal
    {
        public void eat()
        {
            Console.WriteLine("animal is eating");
        }
    }
    public class dog : animal
    {
        public void eat()
        {
            Console.WriteLine("Dog is eating");        }
    }
    public class Account
    {
        int account_balance = 10000;
        public void get_balance(int amount)
        {
            account_balance = amount;
        }
        public void show_balance()
        {
            Console.WriteLine("your account balance is:" + account_balance);
        }
    }

    
    
}

