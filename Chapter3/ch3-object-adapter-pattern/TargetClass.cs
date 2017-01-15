using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_object_adapter_pattern
{
    class TargetClass
    {
        public void MethodB()
        {
            Console.WriteLine("★TargetClass#MethodB()");
            Console.ReadKey();
        }
    }
}
