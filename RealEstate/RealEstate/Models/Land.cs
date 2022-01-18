using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealEstate.ModelBase;

namespace RealEstate.Models
{
    public class Land : IRealEstate
    {
        public int RealEstateID { get; set; }
        public SellType SellType { get; set; }
        public double Square { get; set; }
        public Address Address { get; set; }
        public int BlockNumber{get;set;}
        public int ParcelNumber { get; set; }
        public LandStatus LandStatus { get; set; }

    }
}