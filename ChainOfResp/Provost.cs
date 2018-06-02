namespace CMPS253.GoFPatterns.Behavioral.ChainOfResponsibility
{
    public class Provost : Approver
    {
        public Provost(Approver successor) : base(3.0, successor)
        {
        }
    }
}