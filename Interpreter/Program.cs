using System;
using System.Collections.Generic;

namespace CMPS253.GoFPatterns.Command.Behaviroal.Interpreter
{
    class MainApp
    {
        static void Main()
        {
            //https://www.rapidtables.com/convert/number/how-number-to-roman-numerals.html

            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            // Build the 'parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine(context);
        }
    }
}