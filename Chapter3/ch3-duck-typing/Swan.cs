using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_duck_typing
{
    class Swan //: IDuck
    {
        public void Walk()
        {
            Console.WriteLine("The swan is walking.");
        }
        public void Swim()
        {
            Console.WriteLine("The swan can swim like a duck.");
        }
        public void Quack()
        {
            Console.WriteLine("The swan is quacking.");
        }
    }
}
