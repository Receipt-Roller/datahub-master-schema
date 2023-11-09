using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Represents an audience, defining the target group for a certain content, product, or service.
    /// This class inherits from the base "Thing" class.
    /// </summary>
    public class Audience : Thing
    {
        public Audience(string identifier, string name) : base(identifier, name)
        {
        }

        /// <summary>
        /// Gets or sets the type of audience. This can specify the broad category the audience belongs to.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AudienceType { get; set; }

        /// <summary>
        /// Gets or sets a list of geographic areas relevant to the audience.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Place>? GeographicAreas { get; set; }
    }
}
