using System;

namespace CMPS253.GoFPatterns.Behavioral.ChainOfResponsibility
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

        public virtual void ApproveGA(GraduateAssistant candidate)
        {
            if (candidate.GPA >= limit) //approve if I can
            {
                Console.WriteLine($"[{this.GetType().Name}] approved [{candidate.Name}] ({candidate.GPA} GPA)");
            }
            else if (successor != null) //escalate if I have a supervisor
            {
                successor.ApproveGA(candidate);
            }
            else //call for a meeting if I can't approve and have no supervisor
            {
                Console.WriteLine($"[{this.GetType().Name}] calls for a meeting to discuss the case of [{candidate.Name}] ({candidate.GPA} GPA)");
            }
        }
    }
}