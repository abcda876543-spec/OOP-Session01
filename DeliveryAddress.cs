using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Session01
{
    public struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuidingNumber;
        public DeliveryAddress(string city, string street, int buildingNumber) {
            City = city;
            Street = street;
            BuidingNumber = buildingNumber;
        
        }
        public string GetFullAddress() {
            return $"{Street},{BuidingNumber},{City}";

        }
    }
    public class Customer {
        public string Name;
            }

}
