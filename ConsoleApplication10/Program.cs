using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
           VendingMachine vm = new VendingMachine();

            var inputSodas = new List<ISoda>();


            inputSodas.Add(new Cola(2));
            inputSodas.Add(new Fanta(2));
            inputSodas.Add(new Urge(2));
            inputSodas.Add(new Sprite(2));

            foreach (var soda in inputSodas)
            {
                vm.VmStorage.Sodas.Add(soda);
            }



            Console.WriteLine($"Choose a Soda");

            foreach (var soda in vm.VmStorage.Sodas)
            {
                Console.WriteLine($"id : {soda.Id} {soda.Name} prices : {soda.Price}");
                
            }

            Console.WriteLine("Goodbye");
            Console.ReadLine();
        }


    }
}
