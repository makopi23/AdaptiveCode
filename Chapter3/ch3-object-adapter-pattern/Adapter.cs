using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_object_adapter_pattern
{
    class Adapter : IExpectedInterface
    {
        private TargetClass target;

        public Adapter(TargetClass target)
        {
            this.target = target;
        }

        public void MethodA()
        {
            target.MethodB();
        }
    }
}
