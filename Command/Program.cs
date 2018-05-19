namespace CMPS253.GoFPatterns.Command
{
    public class Program
    {
        static void Main()
        {
            User user = new User(); //invoker

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            System.Console.WriteLine("Undo 3 operations");
            user.Undo(3);
            System.Console.WriteLine("\n\nContinue operating after undo");
            user.Compute('*', 20);
            //user.Redo(3);
        }
    }
}