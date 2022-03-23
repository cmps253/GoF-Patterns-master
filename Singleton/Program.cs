using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger1 = Logger.GetLogger(); 
            var logger2= Logger.GetLogger();//somewhere else in code I need a logger

            Console.WriteLine(logger2==logger1);
            logger1.Log("Hello");
        }
    }
}
