namespace CMPS253.GoFPatterns.Behavioral.ChainOfResponsibility
{
    internal class MainApp
    {
        private static void Main()
        {
            // Setup Chain of Responsibility
            Approver provost = new Provost(null);
            Approver dean = new Dean(provost);
            Approver deptChair = new DepartmentChair(dean);

            // Approve candidates
            //GraduateAssistant p = new GraduateAssistant("201500001", 3.8, "Sally Jones");
            //deptChair.ApproveGA(p);

            //var p = new GraduateAssistant("201500002", 3.4, "Adam Bing");
            //deptChair.ApproveGA(p);

            //var p = new GraduateAssistant("201500003", 3.0, "Lucas Jade");
            //deptChair.ApproveGA(p);

            var p = new GraduateAssistant("201500004", 2.9, "Joe Smith");
            deptChair.ApproveGA(p);
        }
    }
}