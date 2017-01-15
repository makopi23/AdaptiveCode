using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_adapter_pattern
{
    class Adaptee
    {
        public void MethodB()
        {
            Console.WriteLine("★Adaptee#MethodB()");
            Console.ReadKey();
        }
    }
}
