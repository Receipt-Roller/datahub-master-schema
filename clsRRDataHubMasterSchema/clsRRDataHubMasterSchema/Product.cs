using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Represents a product with various characteristics.
    /// </summary>
    public class Product : Thing
    {
        public Product(string identifier, string name) : base(identifier, name)
        {
        }

        // Parameterless constructor for deserialization
        public Product() : base()
        {
            // Initialization specific to Product, if necessary
        }

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
        public bool HasAdultConsideration { get; set; }

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

    }
}
