using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Storage
    {
        public Storage()
        {
 
        }
        public List<ISoda> Sodas { get; set; } = new List<ISoda>();
        int MoneyDeposit
        {
            get;
            set;
        }
    }
}
