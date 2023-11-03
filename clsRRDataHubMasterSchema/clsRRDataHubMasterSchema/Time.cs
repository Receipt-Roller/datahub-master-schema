using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class Time
    {
        public Trip ArrivalTime { get; set; }
        public ActionAccessSpecification AvailabilityEnds { get; set; }
        public ActionAccessSpecification AvailabilityStarts { get; set; }
    }
}
