using System;
using System.Collections.Generic;

namespace CMPS253.GoFPatterns.Behavioral.Interpreter
{
    class MainApp
    {
        static void Main()
        {
            //https://www.rapidtables.com/convert/number/how-number-to-roman-numerals.html

            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            List<BaseExpression> tree = new List<BaseExpression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            foreach (BaseExpression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine(context);
        }
    }
}