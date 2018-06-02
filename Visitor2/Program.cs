namespace CMPS253.GoFPatterns.Behavioral.Visitor2
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new Room() { Name = "Bliss 205" };
            var painter = new PaintVisitor();
            var electrician = new ElectricianVisitor();
            room.Accept(painter);
            room.Accept(electrician);
        }
    }
}
