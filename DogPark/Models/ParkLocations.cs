using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogPark.Models
{
    public class ParkLocations
    {
        public string ParkName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Zip { get; set; }
        public string ParkType { get; set; }
        public decimal lat { get; set; }
        public decimal lng { get; set; }
    }
}