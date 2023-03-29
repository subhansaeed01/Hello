using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Customer
    {
        string _firstname;
        string _lastname;
        public Customer() 
            : this("no first name provided","no last name provided")
        { 
        }
        public Customer(string firstname, string lastname)
        {
            this._firstname = firstname;
            this._lastname = lastname;
        }
        public void PrintFULLName()
        {
            Console.WriteLine("Full Name = {0}", this._firstname+" "+this._lastname);
        }
        ~Customer()
        {

        }
    }
}
