using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Address EmpAddress { get; set; }

        #region Copy Methods
        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }

        public Employee DeepCopy()
        {
            Employee other = (Employee)this.MemberwiseClone();
            other.EmpAddress = new Address(this.EmpAddress.DoorNumber,
                this.EmpAddress.StreetNumber, this.EmpAddress.Zipcode,
                this.EmpAddress.Country);
            return other;
        }

        public override string ToString()
        {
            return string.Format("Emp ID :{0}, Emp Name : {1}, {2}",
                this.ID, this.Name, this.EmpAddress.ToString());
        }

        #endregion
    }
}
