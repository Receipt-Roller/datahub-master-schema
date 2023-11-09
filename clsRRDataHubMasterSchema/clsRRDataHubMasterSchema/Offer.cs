using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class Offer : Thing
    {
        public Offer(string identifier, string name) : base(identifier, name)
        {
        }

        public List<string> AcceptedPaymentMethods { get; set; }
        public List<Offer> AddOns { get; set; }
        public QuantitativeValue AdvanceBookingRequirement { get; set; }
        public AggregateRating AggregateRating { get; set; }
        public List<Place> AreaServed { get; set; }
        public string Asin { get; set; }
        public string Availability { get; set; }
        public Time AvailabilityEnds { get; set; }

        public Time AvailabilityStarts { get; set; }
        public List<Place> AvailableAtOrFrom { get; set; }

        public List<string> DeliveryMethods { get; set; }
        public string BusinessFunction { get; set; }
        public string Category { get; set; }
        public string CheckoutPageURLTemplate { get; set; }
        public QuantitativeValue DeliveryLeadTime { get; set; }
        public List<string> EligibleCustomerType { get; set; }
        public QuantitativeValue EligibleDuration { get; set; }
        public QuantitativeValue EligibleQuantity { get; set; }
        public List<Place> EligibleRegion { get; set; }
        public PriceSpecification EligibleTransactionVolume { get; set; }
        public string Gtin { get; set; }
        public string Gtin12 { get; set; }
        public string Gtin13 { get; set; }
        public string Gtin15 { get; set; }
        public string Gtin8 { get; set; }
        public bool HasAdultConsideration { get; set; }
        public QuantitativeValue HasMeasurement { get; set; }
        public MerchantReturnPolicy HasMerchantReturnPolicy { get; set; }

        public List<TypeAndQuantityNode> IncludesObjects { get; set; }
        public List<Place> IneligibleRegions { get; set; }
        public QuantitativeValue InventoryLevel { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public string ItemCondition { get; set; }
        public Product ItemOfferedProduct { get; set; }
        public QuantitativeValue LeaseLength { get; set; }
        public string Mpn { get; set; }
        public Organization OfferedByOrganization { get; set; }
        public Person OfferedByPerson { get; set; }
        public int Price { get; set; }
        public string PriceCurrency { get; set; }
        public PriceSpecification PriceSpecification { get; set; }
        public DateTime PricevalidUntil { get; set; }
        public Review Review { get; set; }
        public Organization SellerOrganizaion { get; set; }
        public Person SellerPerson { get; set; }
        public string SerialNumber { get; set; }
        public OfferShippingDetails ShippingDetails { get; set; }
        public string Sku { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidThrough { get; set; }
        public WarrantyPromise Warranty { get; set; }
    }
}
