using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DpStrategy
{
    class StrategyImpl3 : IStrategy
    {
        public void Appliquer()
        {
            Console.WriteLine("Stratégie par défaut");
        }
    }
}
