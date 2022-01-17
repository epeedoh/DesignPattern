using System;

namespace DpStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Context context = new Context();

            context.appliquerStrategy(0);
            context.appliquerStrategy(1);
            context.appliquerStrategy(2);
            context.appliquerStrategy(9);

        }
    }
}
