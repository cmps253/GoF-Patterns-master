using System;

namespace CMPS253.GoFPatterns.ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver successor;
        protected double limit;

        public Approver(double limit, Approver successor)
        {
            this.limit = limit;
            this.successor = successor;
        }

        public virtual void ApproveGA(GraduateAssistant ga)
        {
            if (ga.GPA >= limit) //approve if I can
            {
                Console.WriteLine($"[{this.GetType().Name}] approved [{ga.Name}] ({ga.GPA} GPA)");
            }
            else if (successor != null) //escalate if I have a supervisor
            {
                successor.ApproveGA(ga);
            }
            else //call for a meeting if I can't approve and have no supervisor
            {
                Console.WriteLine($"[{this.GetType().Name}] calls for a meeting to discuss the case of [{ga.Name}] ({ga.GPA} GPA)");
            }
        }
    }
}