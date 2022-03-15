using System.Runtime.Serialization;

namespace ODataWebApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public JobTitle JobTitle { get; set; }

        public Address Location { get; set; }
    }

    public class Address
    {
        public string City { get; set; }

        public string Street { get; set; }
    }

    public enum JobTitle
    {
        [EnumMember(Value = "Software Development Engineer")]
        SDE,

        [EnumMember(Value = "Product Manager")]
        PM,

        Designer,

        Partner,

        Tester,
    }
}
