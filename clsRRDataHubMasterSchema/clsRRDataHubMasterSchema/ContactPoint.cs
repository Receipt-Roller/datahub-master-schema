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
    /// Represents a contact point, a means of communication with an organization or individual.
    /// </summary>
    /// <remarks>
    /// This can be used for various types of contact points, such as customer service, technical support, etc.
    /// </remarks>
    public class ContactPoint : Thing
    {
        /// <summary>
        /// Gets or sets the areas served by this contact point.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Place>? AreasServed { get; set; }

        /// <summary>
        /// Gets or sets the languages available for communication.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Language>? AvailableLanguages { get; set; }

        /// <summary>
        /// Gets or sets the contact options, e.g., toll-free numbers or support for hearing-impaired callers.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ContactPoint>? ContactOptions { get; set; }

        /// <summary>
        /// Gets or sets the type of the contact point, e.g., customer service, technical support.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ContactType { get; set; }

        /// <summary>
        /// Gets or sets the email address associated with the contact point.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the fax number associated with the contact point.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FaxNumber { get; set; }

        /// <summary>
        /// Gets or sets the hours during which the contact point is available.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public OpeningHourSpecification? HoursAvailable { get; set; }

        /// <summary>
        /// Gets or sets the products or services supported by this contact point.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? ProductSupported { get; set; }

        /// <summary>
        /// Gets or sets the telephone number associated with the contact point.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Telephone { get; set; }
    }
}
