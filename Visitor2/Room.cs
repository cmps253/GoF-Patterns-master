namespace CMPS253.GoFPatterns.Behavioral.Visitor2
{
    public class Room : IVisitable
    {
        public string Name;

        public void Accept(IVisitor visitor)
        {
            //System.Console.WriteLine(Name);
            visitor.Visit(this);
        }
    }
}
