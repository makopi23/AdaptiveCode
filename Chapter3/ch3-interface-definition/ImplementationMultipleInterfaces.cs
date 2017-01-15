using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_interface_definition
{
    class ImplementationMultipleInterfaces : IInterfaceOne, IInterfaceTwo
    {
        public void MethodOne()
        {
            //throw new NotImplementedException();
        }

        public void MethodTwo()
        {
            //throw new NotImplementedException();
        }
    }
}
