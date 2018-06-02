namespace CMPS253.GoFPatterns.Behavioral.Command
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}