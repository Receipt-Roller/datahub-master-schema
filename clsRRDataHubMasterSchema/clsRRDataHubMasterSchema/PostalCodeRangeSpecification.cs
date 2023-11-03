using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class PostalCodeRangeSpecification : Thing
    {
        public string PostalCodeBegin { get; set; }
        public string PostalCodeEnd { get; set; }
    }
}
