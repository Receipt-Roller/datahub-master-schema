using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// The most generic type of item.
    /// </summary>
    /// <remarks>
    /// See <a href="https://schema.org/Thing">schema.org/PostalAddress</a> for related information.
    /// </remarks>
    public class Thing
    {

        // Thing
        public string AdditionalType { get; set; }

        public string AlternateName { get; set; }
        public string Description { get; set; }
        public string DisambiguatingDescription { get; set; }
        public string Identifier { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string PotentialAction { get; set; }
        public string SameAs { get; set; }
        public string SubjectOf { get; set; }
        public string Url { get; set; }
    }
}
