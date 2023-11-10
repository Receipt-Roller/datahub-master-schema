using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class Rating : Thing
    {
        public Rating(string identifier, string name) : base(identifier, name)
        {
        }

        public Rating() : base()
        {
          
        }

        public List<Person>? AuthorPersons { get; set; }
        public List<Organization>? AuthorOrganizations { get; set; }
        public int? BestRating { get; set; }
        public string? RatingExplanation { get; set; }
        public int? RatingValue { get; set; }
        public string? ReviewAspect { get; set; }
        public int? WorstRating { get; set; }
    }
}
