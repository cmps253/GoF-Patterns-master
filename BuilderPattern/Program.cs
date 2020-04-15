using System.Diagnostics;
using System.IO;

namespace CMPS253.GoFPatterns.Creational.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //DIV();
            CSS();
            //CSS2();
            //XML();

            //var Persons = new XElement("Persons");
            //var person = new XElement("Person");
            //Persons.Add(person);
            //person.Add(new XAttribute("Id", 5));
            //var name = new XElement("name");
            //name.Add(new XAttribute("first", "Joe"));
            //name.Add(new XAttribute("last", "Smith"));
            //person.Add(name);
            //System.Console.WriteLine(Persons.ToString());
        }
        private static void DIV()
        {
            const string FILE = "c:/temp/index.html";
            var div = DivBuilder.CreateInstance("Hello from CMPS 253").Build();
            System.Console.WriteLine(div);
            File.WriteAllText(FILE, div.ToString());
            Process.Start(FILE);
        }
        private static void CSS2()
        {
            const string FILE = "c:/temp/index.html";
            var style1 = StyleBuilder.CreateInstance().AddBackColor("red").Build();
            var style2 = StyleBuilder.CreateInstance().AddColor("yellow").Build();
            var style3 = StyleBuilder.CreateInstance().AddFontSize(2.5F).Build();
            var style = style1.Add(style2).Add(style3);
            var div = DivBuilder.CreateInstance("Hello from CMPS 253").AddStyle(style).Build();
            System.Console.WriteLine(style);
            System.Console.WriteLine(div);
            File.WriteAllText(FILE, div.ToString());
            Process.Start(FILE);
        }
        private static void CSS()
        {
            const string FILE = "c:/temp/index.html";

            var style = StyleBuilder.CreateInstance().AddBackColor("Blue").AddColor("yellow").AddColor("green").AddFontSize(42.5F).Build();
            var div = DivBuilder.CreateInstance("Hello from CMPS 253").AddStyle(style).Build();
            File.WriteAllText(FILE, div.ToString());
            Process.Start(FILE);
            return;

            //to know the possiblities, this line replaces the two lines above it.
            DivBuilder.CreateInstance("Hello from CMPS 253").AddStyle(StyleBuilder.CreateInstance().AddBackColor("red").AddColor("yellow").AddColor("green").AddFontSize(2.5F).Build()).Build();

            System.Console.WriteLine(style);
            System.Console.WriteLine(div);
        }
        private static void XML()
        {
            var name = ElementBuilder.CreateInstance("name").AddAttribute("first", "Joe").AddAttribute("last", "Smith").Build();
            var p = ElementBuilder.CreateInstance("Person").AddAttribute("id", 1).AddChild(name).Build();
            var s = ElementBuilder.CreateInstance("Persons").AddChild(p).Build();
            System.Console.WriteLine(s);
        }
    }
}