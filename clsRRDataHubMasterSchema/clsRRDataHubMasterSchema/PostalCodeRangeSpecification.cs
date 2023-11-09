using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class PostalCodeRangeSpecification : Thing
    {
        public PostalCodeRangeSpecification(string identifier, string name) : base(identifier, name)
        {
        }
        public string PostalCodeBegin { get; set; }
        public string PostalCodeEnd { get; set; }
    }
}
