using System;

namespace CMPS253.GoFPatterns.Behavioral.Command
{
    public class CalculatorCommand : Command //Invoker
    {
        private Calculator calculator;

        public char Operator { get; private set; }
        public int Operand { get; private set; }

        public CalculatorCommand(Calculator calculator, char oper, int operand)
        {
            this.calculator = calculator;
            this.Operator = oper;
            this.Operand = operand;
        }

        public override void Execute()
        {
            calculator.Operation(Operator, Operand);
        }

        public override void UnExecute()
        {
            calculator.Operation(Undo(Operator), Operand);
        }

        private char Undo(char oper)
        {
            switch (oper)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default:
                    throw new ArgumentException($"Undefined undo operation for operator {oper}.");
            }
        }
    }
}
