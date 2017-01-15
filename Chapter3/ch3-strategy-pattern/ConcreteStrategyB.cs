using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_strategy_pattern
{
    class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("★ConcreteStrategyB.Excecute()");
        }
    }
}
