namespace CMPS253.GoFPatterns.Behavioral.Interpreter
{
    public class Context
    {
        string originalInput;
        public string Input { get; internal set; }
        public int Output { get; internal set; }

        public Context(string input)
        {
            this.Input = input;
            this.originalInput = input;
        }

        public override string ToString()
        {
            return $"{originalInput} = {Output}";
        }
    }
}
