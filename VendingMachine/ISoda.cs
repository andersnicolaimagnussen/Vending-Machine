using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    interface ISoda
    {

        int Id { get; }
        string Name
        {
            get;
        }
        int Price
        {
            get;
            set;
        }

    }
}
