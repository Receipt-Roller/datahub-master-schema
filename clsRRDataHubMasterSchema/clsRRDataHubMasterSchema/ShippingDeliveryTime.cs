using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class ShippingDeliveryTime : Thing
    {
        public ShippingDeliveryTime(string identifier, string name) : base(identifier, name)
        {
        }
        public OpeningHourSpecification BusinessDays { get; set; }
        public Time CutoffTime { get; set; }    
        public QuantitativeValue HandlingTime { get; set; }
        public QuantitativeValue TransitTime { get; set; }
    }
}
