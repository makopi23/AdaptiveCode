using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_strategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            for(int i = 0; i < 10; i++)
            {
                Console.Write(i + " : ");
                context.DoSomething();
            }
            Console.ReadKey();
        }
    }
}
