using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class WarrantyPromise : Thing
    {
        public QuantitativeValue DurationOfWarranty { get; set; }
        public string WarrantyScope { get; set; }
    }
}
