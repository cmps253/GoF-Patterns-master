using System;

namespace CMPS253.AdvancedTopics.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("Al", "BdeirBdeirBdeir");
            var info = p.GetType();
            foreach (var member in info.GetMembers())
            {
                Console.WriteLine(member.Name);
            }
        }
    }
}
