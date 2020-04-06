using System;

namespace SingletonLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetLogger();

            //assume this is done somewhere 'far' in the code
            Logger logger2 = Logger.GetLogger();

            logger2.ChangeLogformat("ddd MMM, dd, yyyy");

            logger1.Log("hello"); //writing to the same log file as logger2 because both of them got initialized from the same config file
            logger2.Log("hello");

            Console.WriteLine(logger1);
            Console.WriteLine(logger2);

            Console.WriteLine(logger1==logger2); //proof that they are the same object: result = true.
        }
    }
}