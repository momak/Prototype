using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeConsole
{
    public partial class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }

        public override string ToString()
        {
            //return $" Name : {this.Name}  " +
            //       $"DepartmentID : {this.DepartmentID.ToString()}";

            return $" Name : {this.Name}  " +
                   $"DepartmentID : {this.DepartmentID.ToString()}, {this.AddressDetails}";
        }
    }

    public partial class Employee : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    public partial class Employee
    {
        public Address AddressDetails { get; set; }
    }

}
