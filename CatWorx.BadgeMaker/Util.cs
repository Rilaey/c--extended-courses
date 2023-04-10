// import correct packages
using System;
using System.IO;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Util
    {
        public static void PrintEmployees(List<Employee> employees)
        {
            // write entered employee into console after entering info
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
            }
        }
        public static void MakeCSV(List<Employee> employees)
        {
            // create new folder "data" if it doesn't exist
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }

            // write to file
            using (StreamWriter file = new StreamWriter("data/employees.csv"))
            {
                // create the top line of the file so the columns are organized.
                file.WriteLine("ID, Name, PhotoUrl");

                // Loop over employees
                for (int i = 0; i < employees.Count; i++)
                {
                    // Write each employee to the file
                    string template = "{0},{1},{2}";
                    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
                }
            }

            // read file
            using (StreamReader file = new StreamReader("data/employees.csv"))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}