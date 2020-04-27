using System.Collections.Generic;

namespace CMPS253.GoFPatterns.Behavioral.Observer
{
    class MainApp
    {
        static void Main()
        {
            var CMPS253 = new Course("CMPS 253", 102);
            
            List<Student> Students = new List<Student>();
            for (int i = 0; i < 105; i++)
            {
                var s = new Student($"s{i+1}");
                Students.Add(s);
                CMPS253.Register(s);
            }

            CMPS253.Drop(Students[3]);
            CMPS253.Drop(Students[6]);
            CMPS253.Drop(Students[56]);
            CMPS253.Drop(Students[87]);
            CMPS253.Drop(Students[81]);
        }
    }
}