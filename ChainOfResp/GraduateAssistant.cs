namespace CMPS253.GoFPatterns.Behavioral.ChainOfResponsibility
{
    public class GraduateAssistant
    {
        public GraduateAssistant(string aubId, double gpa, string name)
        {
            this.AUBID= aubId;
            this.GPA = gpa;
            this.Name = name;
        }

        public string AUBID { get; set; }
        public double GPA { get; set; }
        public string Name { get; set; }
    }
}