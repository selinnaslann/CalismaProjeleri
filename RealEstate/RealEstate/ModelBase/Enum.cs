using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstate.ModelBase
{
    public enum HeatingType
    {
        NaturalGas,
        AirCondition,
        Stove,
        CentralHeating
    }

    public enum ResidentialType
    {
        Flat,
        Residence,
        Villa,
        FarmHouse
    }
    public enum SellType
    {
        ForSale,
        ForRent
    }

    public enum LandStatus
    {
        Allocation,
        DetachedParcel,
        JointTitleDeed,
        RighttoUseOwnership
    }
    public enum CommercialType
    {
        ForSale,
        ForRent,
        WithAssets,
        LeaseTakeOver
    }
    public enum PropertyType
    {
        Bureau_Office,
        Atölye,
        BanquetHall_EventsVenue,
        OfficePlaza

    }
}