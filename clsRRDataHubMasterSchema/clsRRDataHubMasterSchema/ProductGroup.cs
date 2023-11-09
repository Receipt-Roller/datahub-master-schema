using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class ProductGroup : Product
    {
        public ProductGroup(string identifier, string name) : base(identifier, name)
        {
        }

        public Product HasVariant { get; set; }
        public string ProductGroupId { get; set; } 
        public string VariesBy { get; set; }
    }
}
