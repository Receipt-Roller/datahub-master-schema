using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Represents a postal address as defined by schema.org's PostalAddress structure.
    /// </summary>
    /// <remarks>
    /// See <a href="https://schema.org/PostalAddress">schema.org/PostalAddress</a> for related information.
    /// This class inherits from the 'Thing' class and provides detailed properties for an address,
    /// including the country, locality, region, post office box number, postal code, and street address.
    /// It has two constructors: one parameterless for deserialization purposes and one that accepts an identifier and name.
    /// </remarks>
    public class PostalAddress : Thing
    {
        /// <summary>
        /// Initializes a new instance of the PostalAddress class using the specified identifier and name.
        /// This constructor is typically used when creating a PostalAddress object that needs a unique identifier and a human-readable name.
        /// </summary>
        /// <param name="identifier">A unique identifier for the postal address.</param>
        /// <param name="name">The human-readable name for the postal address.</param>
        public PostalAddress(string identifier, string name) : base(identifier, name)
        {
        }

        /// <summary>
        /// Parameterless constructor for deserialization.
        /// This constructor is used by deserialization mechanisms to create an instance of PostalAddress without initializing it with external data.
        /// </summary>
        public PostalAddress() : base()
        {
            // Initialization if necessary
        }

        /// <summary>
        /// Gets or sets the country component of the address.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AddressCountry { get; set; }

        /// <summary>
        /// Gets or sets the locality or city component of the address.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AddressLocality { get; set; }

        /// <summary>
        /// Gets or sets the region or state component of the address.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AddressRegion { get; set; }

        /// <summary>
        /// Gets or sets the post office box number component of the address.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PostalOfficeBoxNumber { get; set; }

        /// <summary>
        /// Gets or sets the postal code component of the address.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the street address component of the address.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StreetAddress { get; set; }
    }

}
