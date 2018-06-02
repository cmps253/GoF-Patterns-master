using System;

namespace CMPS253.GoFPatterns.Behavioral.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
           
            #region old
            var towns = new Towns();
            var w = new FileWrapper(@"C:\Users\teach\Desktop\253s1\Lebanon_Villages_elevations.csv");
            foreach (var line in w.Records)
            {
                towns.Attach(new Town(line.getTown(), line.getElevation()));
            }

            towns.Accept(new PopulationVisitor());
            towns.Accept(new ElevationVisitor());
            towns.Accept(new Politician());
            towns.Accept(new TownsAbove(1000));
            towns.Visit();
            #endregion
        }
    }
}
