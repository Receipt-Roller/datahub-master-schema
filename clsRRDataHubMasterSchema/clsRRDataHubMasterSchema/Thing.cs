using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// The most generic type of item.
    /// </summary>
    /// <remarks>
    /// See <a href="https://schema.org/Thing">schema.org/Thing</a> for related information.
    /// </remarks>
    public class Thing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Thing"/> class.
        /// </summary>
        /// <param name="identifier">The unique identifier for the Thing.</param>
        /// <param name="name">The name of the Thing.</param>
        public Thing(string identifier, string name)
        {
            Identifier = identifier;
            Name = name;
        }

        // Parameterless constructor for deserialization
        public Thing()
        {
            // Initialize properties if necessary
        }

        /// <summary>
        /// An additional type for the item, typically used to add more specific types from external vocabularies in microdata syntax.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AdditionalType { get; set; }

        /// <summary>
        /// An alternative name for the item.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AlternateName { get; set; }

        /// <summary>
        /// A description of the item.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        /// <summary>
        /// A sub-property of description. A short description of the item used to disambiguate from other, similar items.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DisambiguatingDescription { get; set; }

        /// <summary>
        /// The unique identifier for the item.
        /// </summary>
        public string? Identifier { get; set; }

        /// <summary>
        /// An image of the item.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Image { get; set; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PotentialAction { get; set; }

        /// <summary>
        /// URL of a reference Web page that unambiguously indicates the item's identity.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SameAs { get; set; }

        /// <summary>
        /// A CreativeWork or Event about this Thing.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SubjectOf { get; set; }

        /// <summary>
        /// URL of the item.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Url { get; set; }

      
    }

}
