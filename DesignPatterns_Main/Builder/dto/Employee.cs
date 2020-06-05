using Builder.builder.abstractas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using System.Text;

namespace Builder.dto
{
    public class Employee
    {
        private string name;
        private int age;
        private string gender;
        private Address address;
        private List<Phone> phones;
        private List<Contact> contacts;

        private Employee(string name,int age,string gender,Address address,
            List<Phone> phones, List<Contact> contacts)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
            this.phones = phones;
            this.contacts = contacts;
        }
        public Employee(String name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public Employee()
        {
        }

        public override string ToString()
        {
            return $"Employee( name= {name}  , age= {age} , gender={gender}" +
                $"{Environment.NewLine}, adress= {address} , {Environment.NewLine} " +
                $"phones={string.Join(" ", phones)}"+
                    $",contacs= {string.Join(" ", contacts)}";
        }

        public class EmployeeBuilder : IBuilder<Employee>
        {
            private string name;
            private int age;
            private string gender;
            private Address address;
            private readonly List<Phone> phones = new List<Phone>();
            private readonly List<Contact> contacts = new List<Contact>();

            public EmployeeBuilder setName(string name)
            {
                this.name = name;
                return this;
            }

            public EmployeeBuilder setAge(int age) {
                this.age = age;
                return this;
            }

            public EmployeeBuilder setGender(string gender) {
                this.gender = gender;
                return this;
            }

            public EmployeeBuilder setAddress(string address, string city, string country, string cp) {
                this.address = new Address(address,city,country,cp);
                return this;
            }

            public EmployeeBuilder addPhones(string phoneNumber, string ext, string phoneType) {
                this.phones.Add(new Phone(phoneNumber, ext, phoneType));
                return this;
            }

            public EmployeeBuilder addContacts(string name, string phoneNumber, string ext, 
                string phoneType, string address, string city, string country, string cp) {
                this.contacts.Add(new Contact(name, new Phone(phoneNumber, ext, phoneType),
                    new Address(address, city, country, cp)));
                return this;
            }

            public EmployeeBuilder addContacts(string name, string phoneNumber, string ext, string phoneType)
            {
                this.contacts.Add(new Contact(name, new Phone(phoneNumber, ext, phoneType)));
                return this;
            }

            public Employee Build()
            {
                return new Employee(name, age, gender, address, phones, contacts);
            }
        }
    }
}
