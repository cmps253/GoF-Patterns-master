using System;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace CMPS253.AdvancedTopics
{
    class BaseEntity
    {
        public BaseEntity()
        {
            Type type = this.GetType();
            var members = type.GetMembers(BindingFlags.Public | BindingFlags.Instance);
            foreach (var property in members.Where(p => p.MemberType == MemberTypes.Property))
            {
                Attribute[] attributes = Attribute.GetCustomAttributes(property);
                foreach (Attribute attribute in attributes)
                {
                    var descriptionAttribute = attribute as DescriptionAttribute;
                    if (descriptionAttribute != null)
                    {
                        Console.WriteLine(descriptionAttribute.Description);
                    }
                    var defaultValueAttribute = attribute as DefaultValueAttribute;
                    if (defaultValueAttribute != null)
                    {
                        PropertyInfo propertyInfo = type.GetProperty(property.Name);
                        propertyInfo.SetValue(this, Convert.ChangeType(defaultValueAttribute.Value, propertyInfo.PropertyType), null);
                    }


                    var MaxLenAttr = attribute as MaxLengthAttribute;
                    if(MaxLenAttr!=null)
                    {
                        PropertyInfo propertyInfo = type.GetProperty(property.Name);
                        var instanceValue = propertyInfo.GetValue(this)?.ToString();
                        if (instanceValue?.Length > MaxLenAttr.Length)
                        {
                            throw new FormatException($"{property.Name} has a length of {instanceValue.Length} which exceeds the maximum of {MaxLenAttr.Length}");
                        }
                    }
                }
            }
        }
    }
}
