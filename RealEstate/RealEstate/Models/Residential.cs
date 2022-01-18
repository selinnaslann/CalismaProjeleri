using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealEstate.ModelBase;

namespace RealEstate.Models
{ 
    
    public class Residential : IRealEstate
    {
        public int RealEstateID { get  ; set  ; }
        public SellType SellType { get  ; set  ; }
        public double Square { get  ; set  ; }
        public Address Address { get  ; set  ; }
        public short Age { get; set; }
        public byte FloorNumber { get; set; }
        public HeatingType Heating { get; set; }
        public bool Balcony { get; set; }
        public bool Furnished { get; set; }
        public ResidentialType ResidentialType { get; set; }
        
    }
}