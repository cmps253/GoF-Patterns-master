using System;
using System.Collections.Generic;

namespace CMPS253.GoFPatterns.Behavioral.Strategy
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }
}
