using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class OfferShippingDetails
    {
        public ShippingDeliveryTime DeliveryTime { get; set; }
        public QuantitativeValue Depth { get; set; }
        public bool doesNotShip { get; set; }
        public QuantitativeValue Height { get; set; }
        public DefinedRegion ShippingDestination { get; set; }
        public string ShippingLabel { get; set; }
        public DefinedRegion ShippingOrigin { get; set; }
        public PriceSpecification ShippingRage { get; set; }
        public string ShippingSettingsLink { get; set; }
        public string TransitTimeLabel { get; set; }
        public QuantitativeValue Weight { get; set; }
        public QuantitativeValue Width { get; set; }
    }
}
