using ACE.Hubs;
using Microsoft.AspNet.SignalR;
using System.Web.Http;
using ACE.Models;
using ACE.DAL;

namespace ACE.Controllers
{
    public class LocationController : ApiController
    {
        private EventContext db = new EventContext();
        [HttpPost]
        public IHttpActionResult Post([FromBody] Location location)
        {
            var mappingHub = GlobalHost.ConnectionManager.GetHubContext<MappingHub>();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hubEventParameters = new
            {
                Latitude = location.Latitude,
                Longitude = location.Longitude,
                Title = location.Title,
                Number = location.Number,
                Time = location.Time,
                Pitstop = location.Pitstop,
                Position = location.Position
            };

            mappingHub.Clients.All.locationReceived(hubEventParameters);
            db.Locations.Add(location);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = location.LocationID }, location);
        }
    }
}

