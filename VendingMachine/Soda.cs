using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class Soda : ISoda
    {
        public Soda(int id, string name, int price)
        {
            Id = id;
            Price = price;
            Name = name;
        }

        public int Id { get; }

        public string Name { get; }

        public int Price { get; set; }

    }
}
