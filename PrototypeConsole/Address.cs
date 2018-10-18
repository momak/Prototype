using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeConsole
{
    public class Address
    {
        public Address() { }

        public int DoorNumber { get; set; }
        public int StreetNumber { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return
                $"AddressDetails : Door : {this.DoorNumber}, Street: {this.StreetNumber}, ZipCode : {this.Zipcode.ToString()}," +
                $" Country : {this.Country}";
        }
    }
}
