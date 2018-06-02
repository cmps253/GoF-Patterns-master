using System.Xml.Linq;

namespace CMPS253.GoFPatterns.Creational.Builder
{
    public class ElementBuilder
    {
        XElement root;

        ElementBuilder(string name)
        {
            root = new XElement(name);
        }

        public static ElementBuilder CreateInstance(string name)
        {
            return new ElementBuilder(name);
        }

        public ElementBuilder AddAttribute(string name, object value)
        {
            root.Add(new XAttribute(name, value));
            return this;
        }
        public ElementBuilder AddChild(XElement e)
        {
            root.Add(e);
            return this;
        }
        public XElement Build()
        {
            return this.root;
        }
    }
}
