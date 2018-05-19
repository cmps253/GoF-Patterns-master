namespace Visitor
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
