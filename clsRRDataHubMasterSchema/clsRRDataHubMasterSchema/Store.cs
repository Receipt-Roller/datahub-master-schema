using System.Text.Json.Serialization;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Represents a retail business or store.
    /// </summary>
    /// <remarks>
    /// This class is a representation of a retail entity according to the schema found at https://schema.org/Store. 
    /// It inherits from the 'Thing' class, which provides basic properties like identifier and name.
    /// </remarks>
    public class Store : Thing
    {
        /// <summary>
        /// Initializes a new instance of the Store class with a specific identifier and name.
        /// </summary>
        /// <param name="identifier">A unique identifier for the store.</param>
        /// <param name="name">The name of the store.</param>
        public Store(string identifier, string name) : base(identifier, name)
        {
        }

        // Parameterless constructor for deserialization
        public Store() : base()
        {
            // Initialization specific to Store, if necessary
        }

        /// <summary>
        /// Information about the organization that runs the store, if any.
        /// </summary>
        /// <remarks>
        /// This property can be null if there is no organization information to provide.
        /// </remarks>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Organization? OrganizationInfo { get; set; }

        /// <summary>
        /// The currencies accepted by the store for payment, such as 'USD', 'EUR', etc.
        /// </summary>
        /// <remarks>
        /// This list can be null to indicate that the accepted currencies are not specified.
        /// </remarks>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? CurrenciesAccepted { get; set; }

        /// <summary>
        /// A string representation of the opening hours for the store.
        /// </summary>
        /// <remarks>
        /// The format of this string is not defined by this class and can be null if the opening hours are unspecified.
        /// </remarks>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? OpeningHours { get; set; }

        /// <summary>
        /// The forms of payment accepted by the store, such as 'credit card', 'cash', etc.
        /// </summary>
        /// <remarks>
        /// This list can be null, which means the accepted forms of payment are not defined.
        /// </remarks>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? PaymentAccepted { get; set; }

        /// <summary>
        /// Indicates the price range of the store, typically a string like '$$', '€€€', etc.
        /// </summary>
        /// <remarks>
        /// This value can be null, indicating that the price range is not provided.
        /// </remarks>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PriceRange { get; set; }

        /// <summary>
        /// The physical location of the store as a Place object.
        /// </summary>
        /// <remarks>
        /// If the location is not specified, this property will be null.
        /// </remarks>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Place? Place { get; set; }
    }

}