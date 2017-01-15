using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_strategy_pattern
{
    class Context
    {
        private IStrategy currentStrategy;

        private readonly IStrategy strategyA = new ConcreteStrategyA();
        private readonly IStrategy strategyB = new ConcreteStrategyB();

        public Context()
        {
            currentStrategy = strategyA;
        }

        public void DoSomething()
        {
            currentStrategy = (currentStrategy == strategyA) ? strategyB : strategyA;
            currentStrategy.Execute();
        }
    }
}
