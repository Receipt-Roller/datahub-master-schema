using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class Organization
    {
        public PostalAddress Address { get; set; }
        public List<Place> AreasServed { get; set; }
        public List<Brand> Brands { get; set; }
        
    }
}
