﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShallowCopy();
            ShallowCopyRef();
        }

        public static void ShallowCopy()
        {
            Employee empJohn = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "John",
                DepartmentID = 150,
            };

            Console.WriteLine(empJohn.ToString());

            Employee empSam = (Employee)empJohn.Clone();
            empSam.Name = "Sam Paul";
            Console.WriteLine(empSam.ToString());

            Console.WriteLine("Changed Johns DepartmentID to 161");
            empJohn.DepartmentID = 161;
            Console.WriteLine(empJohn.ToString());
            Console.WriteLine(empSam.ToString());

            Console.ReadLine();
        }

        public static void ShallowCopyRef()
        {
            Employee empJohn = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "John",
                DepartmentID = 150,
                AddressDetails = new Address()
                {
                    DoorNumber = 10,
                    StreetNumber = 20,
                    Zipcode = 90025,
                    Country = "US"
                }
            };

            Console.WriteLine(empJohn.ToString());

            Employee empSam = (Employee)empJohn.Clone();
            empSam.Name = "Sam Paul";
            empSam.DepartmentID = 151;
            empSam.AddressDetails.StreetNumber = 21;
            empSam.AddressDetails.DoorNumber = 11;

            Console.WriteLine(empSam.ToString());
            Console.WriteLine("Modified Details of John");

            empJohn.AddressDetails.DoorNumber = 30;
            empJohn.AddressDetails.StreetNumber = 40;
            empJohn.DepartmentID = 160;


            Console.WriteLine(empJohn.ToString());
            Console.WriteLine(empSam.ToString());

            Console.ReadLine();
        }

    }
}
