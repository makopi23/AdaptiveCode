using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_interface_definition
{
    class SimpleInterfaceImplementation : ISimpleInterface
    {
        public int ThisIntegerPropertyOnlyNeedsAGetter
        {
            get
            {
                return this.encapsulatedInteger;
            }
            set
            {
                this.encapsulatedInteger = value;
            }
        }

        public string ThisStringPropertyNeedsImplementingToo
        {
            get;

            set;
        }

        //public event EventHandler<EventArgs> InterfacesCanContainEventsToo;

        public void ThisMethodRequiresImplementation()
        {
            //throw new NotImplementedException();
        }

        public event EventHandler<EventArgs> InterfacesCanContainEventsToo = delegate { };
        private int encapsulatedInteger;
    }
}
