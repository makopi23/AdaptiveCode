using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_adapter_pattern
{
    class Program
    {
        static Adapter dependecy = new Adapter();
        static void Main(string[] args)
        {
            dependecy.MethodA();
        }
    }
}
