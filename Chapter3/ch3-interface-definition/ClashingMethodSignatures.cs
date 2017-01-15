using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_interface_definition
{
    class ClashingMethodSignatures
    {
        public void MethodA()
        {
            // Todo
        }

        //public int MethodA()
        //{
        //    return 0;
        //}

        public int MethodB(int x)
        {
            return x;
        }

        public int MethodB(int x, int y)
        {
            return x + y;
        }
    }
}
