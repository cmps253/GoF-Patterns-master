namespace CMPS253.GoFPatterns.Behavioral.ChainOfResponsibility
{
    public class DepartmentChair : Approver
    {
        public DepartmentChair(Approver successor) : base(3.5, successor)
        {
        }
    }
}