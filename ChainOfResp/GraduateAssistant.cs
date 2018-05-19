namespace CMPS253.GoFPatterns.ChainOfResponsibility
{
    public class GraduateAssistant
    {
        private string aubId;
        private string name;
        private double gpa;

        public GraduateAssistant(string aubId, double gpa, string name)
        {
            this.aubId = aubId;
            this.gpa = gpa;
            this.name = name;
        }

        public string AUBID
        {
            get { return aubId; }
            set { aubId = value; }
        }

        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}