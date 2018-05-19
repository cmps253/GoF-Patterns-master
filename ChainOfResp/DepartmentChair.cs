namespace CMPS253.GoFPatterns.ChainOfResponsibility
{
    public class DepartmentChair : Approver
    {
        public DepartmentChair(Approver successor) : base(3.5, successor)
        {
        }
    }
}