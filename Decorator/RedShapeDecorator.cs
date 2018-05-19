namespace CMPS253.GoFPatterns.Decorator
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape shapeToDecorate) : base(shapeToDecorate)
        {
        }

        public override void Draw()
        {
            decoratedShape.Draw();
            setRedBorder(this.decoratedShape);
        }

        private void setRedBorder(IShape decoratedShape)
        {
            System.Console.WriteLine("Border Color: Red");
        }

    }
}
