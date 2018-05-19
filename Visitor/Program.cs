using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            //var room = new Room() { Name = "Bliss 205" };
            //var painter = new PaintVisitor();
            //var electrician = new ElectricianVisitor();
            //room.Accept(painter);
            //room.Accept(electrician);
            #region old
            var towns = new Towns();
            var w = new FileWrapper(@"C:\Users\teach\Desktop\253s1\Lebanon_Villages_elevations.csv");
            foreach (var line in w.Records)
            {
                towns.Attach(new Town(line.getTown(), line.getElevation()));
            }

            //towns.Accept(new PopulationVisitor());
            //towns.Accept(new ElevationVisitor());
            //towns.Accept(new Politician());
            towns.Accept(new TownsAbove(1000));
            towns.Visit();
            #endregion
        }
    }
}
