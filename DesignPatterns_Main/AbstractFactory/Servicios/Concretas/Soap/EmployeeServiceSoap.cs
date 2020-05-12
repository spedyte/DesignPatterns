using AbstractFactory.Servicios.Abstractas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Servicios.Concretas.Soap
{
    public class EmployeeServiceSoap : IEmployeeService
    {
        public List<string> getEmployee()
        {
            Console.WriteLine("EmployeeServiceSoap.getEmployee");
            List<string> results = new List<string>() { "Employee Soap 1", "Employee Soap 2", "Employee Soap 3" };
            return results;
        }
    }
}
