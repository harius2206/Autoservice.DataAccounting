using System;
using Common.Entities;

namespace Autoservice.Entities
{
    [Serializable] 
    public class Owner : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public override string Key => Name;

        public override string ToString()
        {
            return string.Format(
                "\tВласник №{0}\n" +
                "\tІм'я: {1}\n" +
                "\tEmail: {2}\n" +
                "\tАдреса: {3}",
                Id,
                Name,
                Email,
                Address
            );
        }

        public Owner(string name, string email, string address)
        {
            Name = name;
            Email = email;
            Address = address;
        }

        public Owner() : this(null, null, null) { }
    }
}