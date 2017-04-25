using ACE.Hubs;
using Microsoft.AspNet.SignalR;
using System.Web.Http;

namespace ACE.Controllers
{
    public class LocationController : ApiController
    {
        [HttpPost]
        public void Post([FromBody] Location location)
        {
            var mappingHub = GlobalHost.ConnectionManager.GetHubContext<MappingHub>();

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
        }
    }

    public class Location
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Title { get; set; }
        public string Number { get; set; }
        public string Time { get; set; }
        public string Pitstop { get; set; }
        public string Position { get; set; }
    }
}

