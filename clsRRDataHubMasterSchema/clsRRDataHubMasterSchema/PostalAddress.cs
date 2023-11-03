using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Postal Address
    /// </summary>
    /// <remarks>
    /// See <a href="https://schema.org/PostalAddress">schema.org/PostalAddress</a> for related information.
    /// </remarks>
    public class PostalAddress : Thing
    {
        public string AddressCountry { get; set; }
        public string AddressLocality { get; set; }
        public string AddressRegion { get; set; }
        public string PostalOfficeBoxNumber { get; set; }
        public string PostalCode { get; set; }
        public string StreetAddress { get; set; }

    }
}
