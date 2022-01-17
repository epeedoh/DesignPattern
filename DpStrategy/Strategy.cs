using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DpStrategy
{
    public class StrategyImpl1 : IStrategy
    {
        public void Appliquer()
        {
            System.Console.WriteLine("J'applique la stratégie Initiale");
        }
    }
}
