using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CMPS253.AdvancedTopics
{
    class Person : BaseEntity
    {
        [DefaultValue("Joe")]
        public string FirstName{ get; set; }

        [Description("this is the last name of the person. It has a maximum length of 10 characters.")]
        [MaxLength(10)]
        public string LastName { get; set; }

        [Obsolete("you should really be using the factory method")]
        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
    }
}
