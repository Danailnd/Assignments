using System;
using System.Collections.Generic;
using System.Text;

namespace Principles_of_Programing_Assignment
{
    class Address
    {
        public string address;
        public string street;
        public string city;
        public string country;
        public string full_address;


        public Address(string Address, string Street, string City, string Country)
        {
            address = Address;
            street = Street;
            city = City;
            country = Country;
            
            
            full_address = Address + " , " + Street + " , " + City + " , " + Country;

        }
    }
}
