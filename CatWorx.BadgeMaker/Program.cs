using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                // first name
                Console.WriteLine("Please enter a first name: (leave empty to exit): ");
                string empFirstName = Console.ReadLine() ?? "";
                if (empFirstName == "")
                {
                    break;
                }

                // last name
                Console.WriteLine("Please enter a last name");
                string empLastName = Console.ReadLine() ?? "";

                // id
                Console.WriteLine("Please enter ID");
                // allows the int to stored as a string to match
                int empId = Int32.Parse(Console.ReadLine() ?? "");

                // photo url
                Console.WriteLine("Please enter photo URL");
                string photoUrl = Console.ReadLine() ?? "";

                // Create a new Employee instance
                Employee currentEmployee = new Employee(empFirstName, empLastName, empId, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;
        }
        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
            }
        }
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}