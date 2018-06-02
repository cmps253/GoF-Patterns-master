namespace CMPS253.GoFPatterns.Behavioral.Visitor
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
