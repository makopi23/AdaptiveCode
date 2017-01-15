using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_object_adapter_pattern
{
    class Program
    {
        static IExpectedInterface dependency = new Adapter(new TargetClass());
        static void Main(string[] args)
        {
            dependency.MethodA();
        }
    }
}
