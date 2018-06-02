namespace CMPS253.GoFPatterns.Behavioral.Visitor2
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
