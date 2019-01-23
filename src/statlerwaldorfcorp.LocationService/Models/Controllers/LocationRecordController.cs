
using System;
using Microsoft.AspNetCore.Mvc;
using statlerwaldorfcorp.LocationService.models;
using statlerwaldorfcorp.LocationService.Persistence;

namespace statlerwaldorfcorp.LocationService.Controllers
{
    [Route("locations/{memberid}")]
    public class LocationRecordController : Controller
    {
        //Test
        private ILocationRecordRepository repository;
        public LocationRecordController(ILocationRecordRepository repo)
        {
            repository = repo;
        }

        [HttpPost]
        public IActionResult AddLocation(Guid memberid,
        [FromBody] LocationRecord locationRecord)
        {
            repository.Add(locationRecord);
            return this.Created($"/location/{memberid}/{locationRecord.ID}",locationRecord );
        }

        [HttpGet]
        public IActionResult GetLocationsForMember(Guid memberId)
        {
            return this.Ok(repository.AllForMember(memberId));
        }

        [HttpGet("latest")]
        public IActionResult GetLatestForMember(Guid memberId)
        {
            return this.Ok(repository.GetLatestForMember(memberId));
        }
    }
}