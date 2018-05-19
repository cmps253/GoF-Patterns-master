namespace CMPS253.GoFPatterns.Decorator2
{
    public abstract class LibraryItem
    {
        public int NumCopies { get; set; }
        public abstract void Display();
    }
}
