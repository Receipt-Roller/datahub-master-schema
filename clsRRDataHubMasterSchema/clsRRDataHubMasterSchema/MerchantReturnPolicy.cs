using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class MerchantReturnPolicy : Thing
    {
        public PropertyValue AdditionalProperty { get; set; }
        public string ApplicableCountry { get; set; }
        public string CustomerRemorseReturnFees { get; set; }
        public string CustomerRemorseReturnLabelSource { get; set; }
        public PriceSpecification CustomerRemorseReturnShippingFeesAmount { get; set; }
        public bool InStoreReturnsOffered { get; set; }
        public string ItemCondition { get; set; }
        public string ItemDefectReturnFees { get; set; }
        public string ItemDefectReturnLabelSource { get; set; }
        public DateTime MerchantReturnDays { get; set; }
        public string MerchantReturnLink { get; set; }
        public string RefundType { get; set ; }
        public PriceSpecification RestockingFee { get; set; }
        public PriceSpecification ReturnFees { get; set; }
        public string ReturnLabelSource { get; set; }
        public string ReturnMethod { get; set; }
        public string ReturnPolicyCategory { get; set; }
        public string ReturnPolicyCountry { get; set; }
        public PriceSpecification ReturnShippingFeesAmount { get; set; }


    }
}
