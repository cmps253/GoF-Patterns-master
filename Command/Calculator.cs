using System;

namespace CMPS253.GoFPatterns.Command
{
    public class Calculator
    {
        private int total = 0;

        public void Operation(char op, int operand)
        {
            switch (op)
            {
                case '+':
                    total += operand;
                    break;
                case '-':
                    total -= operand;
                    break;
                case '*':
                    total *= operand;
                    break;
                case '/':
                    total /= operand;
                    break;
            }
            Console.WriteLine($"Current value = {total} (following {op} {operand})");
        }
    }
}
