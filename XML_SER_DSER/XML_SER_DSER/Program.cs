﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EmployeeLib;

namespace XML_SER_DSER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 16,
                FirstName = "Debendra",
                LastName = "Rout",
                Salary = 50000.00
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextWriter writer = new StreamWriter("E:\\Day-21\\Assignment-21\\XML_SER_DSER\\employee.xml"))
            {
                serializer.Serialize(writer, employee);
                Console.WriteLine("De-Serialization");
                Console.WriteLine($"Id: {employee.Id}");
                Console.WriteLine($"First Name: {employee.FirstName}, Last Name: {employee.LastName}");
                Console.WriteLine($"Salary: {employee.Salary}");
            }
            using (TextReader reader = new StreamReader("E:\\Day-21\\Assignment-21\\XML_SER_DSER\\employee.xml"))
            {
                Employee deserialize = (Employee)serializer.Deserialize(reader);
                Console.WriteLine("De-Serialization");
                Console.WriteLine($"Id: {deserialize.Id}");
                Console.WriteLine($"First Name: {deserialize.FirstName}, Last Name: {deserialize.LastName}");
                Console.WriteLine($"Salary: {deserialize.Salary}");
            }
            Console.ReadKey();

        }
    }
}
