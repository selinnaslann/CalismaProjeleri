using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealEstate.ModelBase;

namespace RealEstate.Models
{
    public class Commercial : IRealEstate
    {
        public int RealEstateID { get  ; set  ; }
        public CommercialType CommercialType { get; set; }
        public PropertyType PropertyType { get; set; }
        public SellType SellType { get  ; set  ; }
        public double Square { get  ; set  ; }
        public Address Address { get  ; set  ; }
        public int FloorNumber { get; set; }
        public HeatingType HeatingType { get; set; }

        


    }
}