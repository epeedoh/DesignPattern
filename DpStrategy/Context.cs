using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DpStrategy
{
    public class Context
    {
        private IStrategy strategy;

        public void appliquerStrategy()
        {
            strategy.Appliquer();
        }

        public void setStrategy()
        {

        }

    //    public void appliquerStrategy(int level)
    //    {
    //        if (level == 0)
    //            System.Console.WriteLine("J'applique la stratégie Initiale");
    //        else if(level == 1)
    //            Console.WriteLine("J'applique la stratégie Niveau 1");
    //         else if (level == 2)
    //            Console.WriteLine("J'applique la stratégie Niveau 2");
    //        else 
    //            Console.WriteLine("Stratégie par défaut");

        //    }
        //}
    }
