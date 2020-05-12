using AbstractFactory.Servicios.Abstractas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Servicios.Concretas.RestFull
{
    public class EmployeeServiceRestFull : IEmployeeService
    {
        public List<string> getEmployee()
        {
            Console.WriteLine("EmployeeServiceRestFull.getEmployees");
            List<string> results = new List<string>() { "Employee REST 1", "Employee REST 2", "Employee REST 3" };
            return results;
        }
    }
}
