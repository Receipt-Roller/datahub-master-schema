using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class ProductGroup : Thing
    {
        /// <summary>
        /// Initializes a new instance of the ProductGroup class with an identifier and a name.
        /// </summary>
        /// <param name="identifier">The unique identifier for the product group.</param>
        /// <param name="name">The name of the product group.</param>
        public ProductGroup(string identifier, string name) : base(identifier, name)
        {
        }

        // Parameterless constructor for deserialization
        public ProductGroup() : base()
        {
            // Initialization specific to ProductGroup, if necessary
        }

        public List<ProductGroup>? ProductSubGroups { get; set; }

        // An additional property of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PropertyValue? AdditionalProperty { get; set; }

        // The aggregate rating of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AggregateRating? AggregateRating { get; set; }

        // The Amazon Standard Identification Number (ASIN) of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Asin { get; set; }

        // The intended audience for the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Audience? Audience { get; set; }

        // Any award associated with the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Award { get; set; }

        // The brand of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Brand? Brand { get; set; }

        // The organization that represents the brand.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Organization? BrandOrganization { get; set; }

        // The category of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Category { get; set; }

        // The color of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Color { get; set; }

        // The country where the product was assembled.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CountryOfAssembly { get; set; }

        // The country where the product was last processed.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CountryOfLastProcessing { get; set; }

        // The country of origin of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CountryOfOrigin { get; set; }

        // The depth of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public QuantitativeValue? Depth { get; set; }

        // The Global Trade Item Number (GTIN) of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Gtin { get; set; }

        // The 12-digit GTIN of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Gtin12 { get; set; }

        // The 13-digit GTIN of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Gtin13 { get; set; }

        // The 15-digit GTIN of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Gtin15 { get; set; }

        // The 8-digit GTIN of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Gtin8 { get; set; }

        // Indicates if the product has adult considerations.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? HasAdultConsideration { get; set; }

        // Details about the energy consumption of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? HasEnergyConsumptionDetails { get; set; }

        // The measurements of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public QuantitativeValue? HasMeasurement { get; set; }

        // The merchant return policy for the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public MerchantReturnPolicy? HasMerchantReturnPolicy { get; set; }

        // The height of the product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public QuantitativeValue? Height { get; set; }

        // The ID within a product group.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? InProductGroupWithID { get; set; }

        // Indicates if the product is an accessory or spare part for another product.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Product? IsAccessoryOrSparePartFor { get; set; }

        // The product for which this product is a consumable.
        public Product? IsConsumableFor { get; set; }

        // Indicates if the product is family friendly.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsFamilyFriendly { get; set; }

        /// <summary>
        /// Represents a specific variant within the product group.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Product>? HasVariant { get; set; }

        /// <summary>
        /// The unique identifier for this product group within a larger grouping or system.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ProductGroupId { get; set; }

        /// <summary>
        /// Describes by which attribute(s) the products in this group vary, such as size, color, etc.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? VariesBy { get; set; }
    }
}
