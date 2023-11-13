using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{

    /// <summary>
    /// Represents a person, inheriting common properties from the Thing class.
    /// This class can be used to model data about individuals.
    /// </summary>
    public class Person : Thing
    {
        public Person(string identifier, string name) : base(identifier, name)
        {
        }

        // Parameterless constructor for deserialization
        public Person() : base()
        {
            // Initialization specific to Person, if necessary
        }

        /// <summary>
        /// Gets or sets the additional name or names of the person. 
        /// This could include middle names, nicknames, or other names used by the person.
        /// The JsonIgnore attribute ensures that this property is ignored during JSON serialization
        /// if it is null, reducing the size of the JSON data when this information is not present.
        /// </summary>
        /// <value>
        /// The additional name or names of the person, or null if not specified.
        /// </value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AdditionalName { get; set; }

        /// <summary>
        /// Gets or sets the postal address of the person.
        /// The PostalAddress object includes properties such as street address, 
        /// locality, region, postal code, and country.
        /// The JsonIgnore attribute ensures that this property is ignored during JSON serialization
        /// if it is null. This is useful when the address is not known or not applicable.
        /// </summary>
        /// <value>
        /// The postal address of the person, represented as a PostalAddress object,
        /// or null if the address is not specified.
        /// </value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PostalAddress? Address { get; set; }

        // Additional properties and methods related to the Person may be added here.
    }
}
