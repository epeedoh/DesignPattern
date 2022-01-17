using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DpStrategy
{
    class StrategyImpl2 : IStrategy
    {
        public void Appliquer()
        {
            Console.WriteLine("J'applique la stratégie Niveau 2");
        }
    }
}
