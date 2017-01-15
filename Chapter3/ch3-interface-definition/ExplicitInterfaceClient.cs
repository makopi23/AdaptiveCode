using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_interface_definition
{
    public class ExplicitInterfaceClient
    {
        public ExplicitInterfaceClient(ExplicitInterfaceImplementation implementationReference,
            ISimpleInterface interfaceReference)
        {
            //var instancePropertyValue = implementationReference.This...
            var interfacePropertyValue = interfaceReference.ThisIntegerPropertyOnlyNeedsAGetter;
            interfaceReference.ThisMethodRequiresImplementation();
            interfaceReference.ThisStringPropertyNeedsImplementingToo = "Hello";
            interfaceReference.InterfacesCanContainEventsToo += EventHandler;
        }

        void EventHandler(object sender, EventArgs e)
        {
            // Todo
        }
    }
}
