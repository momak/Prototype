﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeAbstract
{
    public partial class Employee : CloneablePrototype<Employee>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int DepartmentID { get; set; }

        public Address AddressDetails { get; set; }
        public override string ToString()
        {
            return string.Format(" Name : {0}, DepartmentID : {1} , " +
                                 "Address : {2}",
                this.Name, this.DepartmentID.ToString(),
                this.AddressDetails.ToString());
        }
    }
}
