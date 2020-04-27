namespace CMPS253.GoFPatterns.Behavioral.Command
{
    public class Program
    {
        static void Main()
        {
            //The command pattern is a behavioral design pattern 
            //an object is used to encapsulate all information needed to perform an action or trigger an event at a later time
            //This information includes the method name, the object that owns the method and values for the method parameters.
            //Supports **Undo**
            //Four terms always associated with the command pattern are command, receiver, invoker and client.

            User user = new User(); //invoker

            user.Compute('+', 100); //100
            user.Compute('-', 50); //50
            user.Compute('*', 10); //500
            user.Compute('/', 2); //250

            System.Console.WriteLine("Undo 3 operations");
            user.Undo(3);
            System.Console.WriteLine("\n\nContinue operating after undo");
            user.Compute('*', 20);
            //user.Redo(3);
        }
    }
}