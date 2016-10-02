using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class Cola : Soda
    {
        /*private string _name; This is actually the same as the code example down there. 
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }*/
        public Cola(int price):base (1, "Cola",price)
        {
        }

    }
}
