using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Represents an organization such as a school, NGO, corporation, club, etc.
    /// </summary>
    /// <remarks>
    /// Refer to <see href="https://schema.org/Organization">schema.org/Organization</see> for more information.
    /// </remarks>
    public class Organization : Thing
    {
        public Organization(string identifier, string name) : base(identifier, name)
        {
       

        }

        /// <summary>
        /// The postal address of the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PostalAddress? Address { get; set; }

        /// <summary>
        /// The areas within which the organization is active.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Place>? AreasServed { get; set; }

        /// <summary>
        /// The brands that are associated with or owned by the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Brand>? Brands { get; set; }

        /// <summary>
        /// Departments within the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Organization>? Departments { get; set; }

        /// <summary>
        /// The Dun & Bradstreet DUNS number for identifying an organization.
        /// </summary>
        public string? Duns { get; set; }

        /// <summary>
        /// The email address of the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Email { get; set; }

        /// <summary>
        /// The people employed by the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Person>? Employees { get; set; }

        /// <summary>
        /// The people who founded the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Person>? Founders { get; set; }

        /// <summary>
        /// The date the organization was founded.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? FoundingDate { get; set; }

        /// <summary>
        /// The location where the organization was founded.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Place? FoundingLocation { get; set; }

        /// <summary>
        /// The organization's global location number (GLN).
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? GlobalLocationNumber { get; set; }

        // Some properties are omitted for brevity

        /// <summary>
        /// Keywords or tags used to describe this organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Keywords { get; set; }

        /// <summary>
        /// The legally recognized name of the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? LegalName { get; set; }

        /// <summary>
        /// The Legal Entity Identifier (LEI) code.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? LeiCode { get; set; }

        /// <summary>
        /// The physical location or address of the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Place? Location { get; set; }

        /// <summary>
        /// URL of the logo used by the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Logo { get; set; }

        /// <summary>
        /// Offers made by the organization, such as sales or promotions.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Offer>? MakesOffers { get; set; }

        /// <summary>
        /// The members of the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Person>? Members { get; set; }

        /// <summary>
        /// Other organizations that this organization is a member of.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Organization>? MemberOf { get; set; }

        /// <summary>
        /// An indicator of the number of employees in the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public QuantitativeValue? NumberOfEmployees { get; set; }

        /// <summary>
        /// Parent organizations that this organization is a subsidiary of.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Organization>? ParentOrganizations { get; set; }

        /// <summary>
        /// Reviews about the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Review? Review { get; set; }

        /// <summary>
        /// A slogan or motto associated with the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Slogan { get; set; }

        /// <summary>
        /// The Tax / VAT ID of the organization, e.g., the EIN in the U.S.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TaxId { get; set; }

        /// <summary>
        /// The telephone number of the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Telephone { get; set; }

        /// <summary>
        /// The Value Added Tax ID of the organization.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? VatId { get; set; }
    }

}
