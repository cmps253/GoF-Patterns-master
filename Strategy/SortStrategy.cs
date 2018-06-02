using System.Collections.Generic;

namespace CMPS253.GoFPatterns.Behavioral.Strategy
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
