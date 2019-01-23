
using System;
using System.Collections.Generic;
using statlerwaldorfcorp.LocationService.models;

namespace statlerwaldorfcorp.LocationService.Persistence
{
    public interface ILocationRecordRepository
    {
        LocationRecord Add(LocationRecord locationRecord);
        LocationRecord Update(LocationRecord locationRecord);
        LocationRecord Get(Guid memberId, Guid locationId);
        LocationRecord Delete(Guid memberId, Guid locationId);
        LocationRecord GetLatestForMember(Guid memberId);
        ICollection<LocationRecord> AllForMember(Guid memberId);
    }
}