using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class QuantitativeValue : Thing
    {
        public QuantitativeValue(string identifier, string name) : base(identifier, name)
        {
        }

        public PropertyValue AdditionalProperty { get; set; }
        public long MaxValue { get; set; }
        public long MinValue { get; set; }
        public string UnitCode { get; set; }
        public string UnitText { get; set; }
        public long Value { get; set; }
        public string ValueReference { get; set; }

    }
}
