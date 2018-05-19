using System.Xml.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var style = StyleBuilder.CreateInstance().AddBackColor("red").AddColor("yellow").AddColor("green").AddFontSize(2.5F).Build();
            var div = DivBuilder.CreateInstance("Hello from CMPS 253").AddStyle(style).Build();
            System.Console.WriteLine(div);
            return;
            var name = ElementBuilder.CreateInstance("name").AddAttribute("first", "Joe").AddAttribute("last", "Smith").Build();
            var p = ElementBuilder.CreateInstance("Person").AddAttribute("id", 1).AddChild(name).Build();
            var s = ElementBuilder.CreateInstance("Persons").AddChild(p).Build();

            //System.Console.WriteLine(b.ToString());
            //System.Console.WriteLine(p);
            System.Console.WriteLine(s);
            return;

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
    }
}
