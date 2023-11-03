using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Represents the specifications for accessing a particular action, including eligibility requirements and timings.
    /// This class inherits from the base "Thing" class.
    /// </summary>
    /// <remarks>
    /// Consider checking the appropriate specification documentation or standard for further details on each property.
    /// </remarks>
    public class ActionAccessSpecification : Thing
    {
        /// <summary>
        /// Gets or sets the end time for the availability of the action.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? AvailabilityEnds { get; set; }

        /// <summary>
        /// Gets or sets the start time for the availability of the action.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? AvailabilityStarts { get; set; }

        /// <summary>
        /// Gets or sets the category for the action. It can be a string representation or a defined type.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Category { get; set; }  // Nullable string

        /// <summary>
        /// Gets or sets a list of regions where the action is eligible.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Place>? EligibleRegions { get; set; }

        /// <summary>
        /// Gets or sets an offer that is expected to be accepted for accessing the action.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Offer? ExpectsAcceptanceOf { get; set; }

        /// <summary>
        /// Gets or sets a list of regions where the action is not eligible.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Place>? IneligibleRegions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a subscription is required to access the action.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool RequiresSubscription { get; set; }
    }
}
