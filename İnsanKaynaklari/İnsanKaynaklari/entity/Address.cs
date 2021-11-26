using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari.entity
{
    class Address:Employee
    {
        private string _City;
        private string _Country;
        private string _HouseNumber;
        private string _Street;
        private string _ZipCode;

        public string City { get => _City; set => _City = value; }
        public string Country { get => _Country; set => _Country = value; }
        public string HouseNumber { get => _HouseNumber; set => _HouseNumber = value; }
        public string Street { get => _Street; set => _Street = value; }
        public string ZipCode { get => _ZipCode; set => _ZipCode = value; }

        public Address()
        {

        }

      


    }
}
