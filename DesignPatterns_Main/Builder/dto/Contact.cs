using System;
using System.Collections.Generic;
using System.Runtime.Loader;
using System.Text;

namespace Builder.dto
{
    public class Contact
    {
        private string name;
        private Phone phone;
        private Address address;

        public Contact()
        {

        }

        public Contact(string name,Phone phone,Address address)
        {
            this.name = name;
            this.phone = phone;
            this.address = address;
        }

        public Contact(string name,Phone phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public override string ToString()
        {
            return $"Contact(name={name}, phone={phone})";
        }
    }
}
