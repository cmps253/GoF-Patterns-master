using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger= Logger.GetLogger();
            var logger1 = Logger.GetLogger(); //somewhere else in code I need a logger

            Console.WriteLine(logger==logger1);

            logger1.ChangeFormat("ddd MMM, dd, YYYY: hh:mm");
            Console.WriteLine(logger);
            Console.WriteLine(logger1);
        }
    }
}
