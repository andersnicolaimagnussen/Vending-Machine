using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class VendingMachine
    {
        public Storage VmStorage { get; private set; } = new Storage();
        public VendingMachine()
        {
            Console.WriteLine("Welcome to the vending machine \n here is a collection of all the good sodas you can buy");
            
            
        }

    }
}
