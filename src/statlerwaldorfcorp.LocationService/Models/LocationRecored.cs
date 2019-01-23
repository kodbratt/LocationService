

using System;

namespace statlerwaldorfcorp.LocationService.models
{
    public class LocationRecord
    {
     public Guid ID {get;set;}
     public float Lattitude {get;set;}
     public float Longitude {get;set;}
     public float Altitude {get;set;}
     public long TimeStamp {get;set;}  
     public Guid MemberID {get;set;} 
    }
}