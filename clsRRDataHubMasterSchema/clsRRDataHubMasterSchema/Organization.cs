using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Organization
    /// </summary>
    /// <remarks>
    /// Refer to <see cref="https://schema.org/Organization"/> for more information.
    /// </remarks>
    public class Organization : Thing
    {
        public PostalAddress Address { get; set; }
        public List<Place> AreasServed { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Organization> Departments { get; set; }
        public string Duns { get; set; }
        public string Email { get; set; }
        public List<Person> Employees { get; set; }
        public List<Person> Founders { get; set; }
        public DateTime FoundingDate { get; set; }
        public Place FoundingLocation { get; set; }
        public string GlobalLocationNumber { get; set; }    

        public List<Place> HasPost { get; set; }

        public string IsIcV4 { get; set; }
        public string Iso6523Code { get; set; }
        public List<string> Keywords { get; set; }
        public string LegalName { get; set; }
        public string LeiCode { get; set; }
        public Place Location { get; set; }
        public string Logo { get; set; }
        public List<Offer> MakesOffers { get; set; }
        public List<Person> Members { get; set; }
        public List<Organization> MemberOf { get; set; }
        public QuantitativeValue NumberOfEmployees { get; set; }
        public List<Organization> ParentOrganizations { get; set;}
        public Review Review { get; set; }
        public string Slogan { get; set; }
        public string TaxId { get; set; }   
        public string Telephone { get; set; }   
        public string VatId { get; set; }

    }
}
