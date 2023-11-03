using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Image Object
    /// </summary>
    /// <remarks>
    /// See <a href="https://schema.org/ImageObject">schema.org/ImageObject</a> for related information.
    /// </remarks>
    public class ImageObject
    {
        public string Caption { get; set; }
        public string EmbededTextCaption { get; set; }
        public string exifData { get; set; }
        public bool RepresentativeOfPage { get; set; }
    }
}
