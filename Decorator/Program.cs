namespace CMPS253.GoFPatterns.Structural.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Plain Circle Object");
            IShape circle = new Circle();
            circle.Draw();

            System.Console.WriteLine("\n\nDecorated Circle Object");
            IShape redCircle = new RedShapeDecorator(circle);
            redCircle.Draw();

            System.Console.WriteLine("\n\nDecorated Rectangle Object");
            IShape redRectangle = new RedShapeDecorator(new Rectangle());
            redRectangle.Draw();
        }
    }
}
