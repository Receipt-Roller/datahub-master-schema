using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class Place : Thing
    {
        public PostalAddress Address { get; set; }

        public string BranchCode { get; set; }
        public List<string> ContainedInPlaceIds { get; set; }
        public List<string> ContainsPlaceIds { get; set; }
    }
}
