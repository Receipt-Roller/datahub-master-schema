using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Represents a brand, typically associated with the marketing and identity of a product, service, or company.
    /// </summary>
    /// <remarks>
    /// See <a href="https://schema.org/Brand">schema.org/Brand</a> for related information.
    /// </remarks>
    public class Brand : Thing
    {
        /// <summary>
        /// Gets or sets the aggregate rating for the brand, summarizing reviews and ratings.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AggregateRating? AggregateRating { get; set; }

        /// <summary>
        /// Gets or sets the logo for the brand, providing a visual representation.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ImageObject? Logo { get; set; }

        /// <summary>
        /// Gets or sets a review specific to the brand.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Review? Review { get; set; }

        /// <summary>
        /// Gets or sets the slogan or tagline associated with the brand.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Slogan { get; set; }
    }
}
