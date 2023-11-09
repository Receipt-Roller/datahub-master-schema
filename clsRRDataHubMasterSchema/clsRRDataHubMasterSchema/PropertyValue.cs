using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class PropertyValue : Thing
    {
        public PropertyValue(string identifier, string name) : base(identifier, name)
        {
        }
        public long MaxValue { get; set; }
        public string MeasurementMethod { get; set; }
        public string MeasurementTechnique { get; set; }
        public long MinValue { get; set; }
        public string PropertyId { get; set; }
        public string UnitCode { get; set; }
        public string UnitText { get; set; }
        public long Value { get; set; }

        public string ValueReference { get; set; }
    }
}
