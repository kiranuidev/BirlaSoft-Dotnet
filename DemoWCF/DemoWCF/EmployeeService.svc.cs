﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        public Employee GetEmployeeById()
        {
            return new Employee() { Name = "Sachin", Id = 2000 };
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Name = "Kiran", Id = 100 });
            employees.Add(new Employee() { Name = "Ravu", Id = 101 });

            return employees;
        }
    }
}
