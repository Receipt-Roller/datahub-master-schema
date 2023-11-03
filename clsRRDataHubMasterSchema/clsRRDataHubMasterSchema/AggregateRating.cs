using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Represents an aggregate rating, summarizing reviews and ratings for an item.
    /// </summary>
    public class AggregateRating : Rating
    {
        /// <summary>
        /// Gets or sets the item that has been reviewed and rated.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Thing? ItemReviewed { get; set; }

        /// <summary>
        /// Gets or sets the total count of ratings for the item.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? RatingCount { get; set; }

        /// <summary>
        /// Gets or sets the total count of reviews for the item.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? ReviewCount { get; set; }
    }
}
