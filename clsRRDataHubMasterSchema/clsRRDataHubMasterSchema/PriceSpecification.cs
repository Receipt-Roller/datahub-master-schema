using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class PriceSpecification : Thing
    {
        public PriceSpecification(string identifier, string name) : base(identifier, name)
        {
        }
        public QuantitativeValue EligibleQuantity { get;set; }
        public PriceSpecification EligibleTransactionVolume { get; set; }
        public double MaxPrice { get; set; }
        public double MinPrice { get; set; }
        public double Price { get; set; }
        public string PriceCurrency { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidThrough { get; set; }
        public bool ValueAddedTaxIncluded { get; set; }
    }
}
