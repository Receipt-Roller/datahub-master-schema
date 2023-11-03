using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class Review
    {
        public Review AssociatedClaimReview { get; set; }
        public Review AssociatedMediaReview { get; set; }
        public Review AssociatedReview { get; set; }
        public Thing ItemReviewed { get; set; }
        public List<string> NegativeNotes { get; set; }
        public List<string> PositiveNotes { get; set; }
        public string ReviewAspect { get; set; }
        public string ReviewBody { get; set; }
        public Rating ReviewRating { get; set; }
    }
}
