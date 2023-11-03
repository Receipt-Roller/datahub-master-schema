namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Store
    /// </summary>
    /// See <see cref="https://schema.org/Store"/> for related information.
    public class Store
    {
        // Local Business
        public List<string> CurrenciesAccepted { get; set; }
        public string OpeningHours { get; set; }
        public List<string> PaymentAccepted { get; set; }
        public string PriceRange { get; set; }

        // Organization
        public PostalAddress Address { get; set; }
        public List<Place> AreasServed { get; set; }



    }
}