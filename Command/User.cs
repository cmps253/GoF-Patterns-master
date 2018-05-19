using System;
using System.Collections.Generic;

namespace CMPS253.GoFPatterns.Command
{
    public class User //Invoker
    {
        private Calculator calculator = new Calculator();

        #region Supporting Undo and redo
        private List<Command> stackOfCommands = new List<Command>();
        private int operationsCount = 0;
        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);

            for (int i = 0; i < levels; i++)
            {
                if (operationsCount < stackOfCommands.Count - 1)
                {
                    Command command = stackOfCommands[operationsCount++];
                    command.Execute();
                }
            }
        }
        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);

            for (int i = 0; i < levels; i++)
            {
                if (operationsCount > 0)
                {
                    Command command = stackOfCommands[--operationsCount] as Command;
                    stackOfCommands.RemoveAt(stackOfCommands.Count - 1);
                    command.UnExecute();
                }
            }
        } 
        #endregion

        public void Compute(char @operator, int operand)
        {
            Command command = new CalculatorCommand(calculator, @operator, operand);
            command.Execute();

            stackOfCommands.Add(command);
            operationsCount++;
        }
    }
}