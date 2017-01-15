using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_interface_definition
{
    public class ExplicitInterfaceImplementation : ISimpleInterface
    {
        private int encapsulatedInteger;
        private event EventHandler<EventArgs> encapsulatedEvent;

        public ExplicitInterfaceImplementation()
        {
            this.encapsulatedInteger = 4;
        }

        int ISimpleInterface.ThisIntegerPropertyOnlyNeedsAGetter
        {
            get
            {
                return encapsulatedInteger;
            }
        }

        string ISimpleInterface.ThisStringPropertyNeedsImplementingToo
        {
            get;
            set;
        }

        event EventHandler<EventArgs> ISimpleInterface.InterfacesCanContainEventsToo
        {
            add
            {
                encapsulatedEvent += value;
            }

            remove
            {
                encapsulatedEvent -= value;
            }
        }

        void ISimpleInterface.ThisMethodRequiresImplementation()
        {
            encapsulatedEvent(this, EventArgs.Empty);
        }
    }
}
