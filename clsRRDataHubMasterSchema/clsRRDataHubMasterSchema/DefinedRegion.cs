using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Represents a defined region, which can be a combination of countries, regions, and postal codes.
    /// </summary>
    public class DefinedRegion : Thing
    {
        /// <summary>
        /// Gets or sets the country associated with the defined region.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AddressCountry { get; set; }

        /// <summary>
        /// Gets or sets the specific region or state within the country of the defined region.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AddressRegion { get; set; }

        /// <summary>
        /// Gets or sets the postal code associated with the defined region.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the prefix of the postal code for the defined region.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PostalCodePrefix { get; set; }

        /// <summary>
        /// Gets or sets the range specification for postal codes within the defined region.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PostalCodeRangeSpecification? PostalCodeRange { get; set; }
    }
}
