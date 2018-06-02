namespace CMPS253.GoFPatterns.Structural.Decorator2
{
    public abstract class LibraryItem
    {
        public int NumCopies { get; set; }
        public abstract void Display();
    }
}
