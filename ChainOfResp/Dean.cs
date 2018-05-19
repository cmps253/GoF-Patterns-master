namespace CMPS253.GoFPatterns.ChainOfResponsibility
{
    public class Dean : Approver
    {
        public Dean(Approver successor) : base(3.3, successor)
        {
        }
    }
}