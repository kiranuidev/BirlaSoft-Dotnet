using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeServiceRef.EmployeeServiceClient client= new EmployeeServiceRef.EmployeeServiceClient();
            var result = client.GetEmployees();
            foreach(var emp in result)
            {
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Id);
            }
            Console.ReadKey();
        }
    }
}
