using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Represents a place in the context of the schema.org specifications. 
    /// A place could be a physical location like a building or a natural feature.
    /// </summary>
    /// <seealso cref="https://schema.org/Place">For more information on the Place schema.</seealso>
    public class Place : Thing
    {
        /// <summary>
        /// The postal address of the place. This can include the street address, post office box number,
        /// city, postal code, and country.
        /// </summary>
        /// <value>The postal address or null if not available.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PostalAddress? Address { get; set; }

        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business.
        /// This code is typically used by a parent organization to distinguish between different locations
        /// or branches and may be used within structured URLs to refer to a specific branch or location.
        /// </summary>
        /// <value>The branch code or null if not applicable.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BranchCode { get; set; }

        /// <summary>
        /// A collection of identifiers representing other places within which this place is contained.
        /// For example, a museum might be contained within a park which is in turn contained within a city.
        /// These identifiers can be used to navigate a hierarchy of places.
        /// </summary>
        /// <value>A list of strings representing the IDs or null if there are none.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? ContainedInPlaceIds { get; set; }

        /// <summary>
        /// A collection of identifiers representing any places that are contained within this place.
        /// For example, if the place represents a city, this list could contain identifiers for landmarks,
        /// parks, buildings, or neighborhoods within the city.
        /// </summary>
        /// <value>A list of strings representing the IDs or null if there are none.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? ContainsPlaceIds { get; set; }

        /// <summary>
        /// Geographical coordinates of the place, providing latitude and longitude to define the
        /// physical location on Earth. This is useful for mapping and location services.
        /// </summary>
        /// <value>The geographical coordinates or null if not available.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public GeoCoordinates? Geo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Place"/> class with a unique identifier and a name.
        /// This constructor is typically used when creating a new Place object that needs to be identified
        /// within a system or when integrating with external APIs that require an ID.
        /// </summary>
        /// <param name="identifier">The unique identifier for the Place.</param>
        /// <param name="name">The name of the Place, such as "Eiffel Tower" or "Central Park".</param>
        public Place(string identifier, string name) : base(identifier, name)
        {
            // The constructor passes the identifier and name up to the base Thing class,
            // which could assign these properties to all inheriting classes, ensuring that each
            // Place has a unique ID and a human-readable name.
        }
        // Parameterless constructor for deserialization
        public Place() : base()
        {
            // Initialization specific to Place, if necessary
        }
    }


}
