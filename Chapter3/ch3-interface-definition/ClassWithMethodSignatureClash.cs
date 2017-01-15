using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_interface_definition
{
    public class ClassWithMethodSignatureClash : IInterfaceOne
    {
        public void MethodOne()
        {

        }
    }
}
