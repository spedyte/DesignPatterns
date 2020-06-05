using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.dto
{
    public class Address
    {
        private string address;
        private string city;
        private string country;
        private string cp;

        public Address(string address,string city,string country,string cp)
        {
            this.address = address;
            this.city = city;
            this.country = country;
            this.cp = cp;
        }

        public override string ToString()
        {
            return $"Address( address={address} , city={city}, country={country}, cp={cp})";
        }
    }
}
