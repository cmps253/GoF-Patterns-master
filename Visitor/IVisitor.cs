namespace CMPS253.GoFPatterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visit(IVisitable element);
    }
}
