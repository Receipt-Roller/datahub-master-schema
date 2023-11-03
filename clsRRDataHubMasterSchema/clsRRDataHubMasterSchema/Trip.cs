using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class Trip : Thing
    {
        public Time ArrivalTime { get; set; }
        public Time DepartureTime { get; set; }
        public List<Place> Itinerary { get; set; }
        public List<Offer> Offers { get; set; }
        public Trip PartOfTrip { get; set; }
        public Organization ProviderOrganization { get;set; }
        public Person ProviderPerson { get; set; }
        public List<Trip> SubTrips { get; set; }
        public Place TripOrigin { get; set; }
    }
}
