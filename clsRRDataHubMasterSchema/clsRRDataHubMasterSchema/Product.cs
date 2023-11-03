using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class Product : Thing
    {
        public PropertyValue AdditionalProperty { get; set; }
        public AggregateRating AggregateRating { get; set; }
        public string Asin { get; set; }
        public Audience Audience { get; set; }
        public string Award { get; set; }
        public Brand Brand { get; set; }
        public Organization BrandOrganization { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public string CountryOfAssembly { get; set; }
        public string CountryOfLastProcessing { get; set; }
        public string CountryOfOrigin { get; set; }
        public QuantitativeValue Depth { get; set; }
        public string Gtin { get; set; }
        public string Gtin12 { get; set; }
        public string Gtin13 { get; set; }
        public string Gtin15 { get; set; }
        public string Gtin8 { get; set; }
        public bool HasAdultConsideration { get; set; }
        public string HasEnergyConsumptionDetails { get; set; }
        public QuantitativeValue HasMeasurement { get; set; }
        public MerchantReturnPolicy HasMerchantReturnPolicy { get; set; }
        public QuantitativeValue Height { get; set; }
        public string InProductGroupWithID { get; set; }
        public Product IsAccessoryOrSparePartFor { get; set; }
        public Product IsConsumableFor { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public List<Product> IsRelatedTo { get; set; }
        public List<Product> IsSimilarTo { get; set; }

        public ProductGroup IsVariantOf { get; set; }
        public string ItemCondition { get; set; }
        public List<string> Keywords { get; set; }

        public ImageObject Logo { get; set; }
        public Organization Manufacture { get; set; }
        public List<string> Materials { get; set; }
        public string Model { get; set; }
        public string Mpn { get; set; }
        public List<string> NegativeNotes { get; set; }
        public string Nsn { get; set; }
        public List<Offer> Offers { get; set; } 
        public string pattern { get; set; }
        public List<string> PositiveNotes { get; set; }
        public string ProductId { get; set; }

        public DateTime PuroductionDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Review Review { get; set; }
        public QuantitativeValue Size { get; set; }
        public string Sku { get; set; }
        public string Slogan { get; set; }
        public QuantitativeValue Weight { get; set; }
        public QuantitativeValue Width { get; set; }
    }
}
