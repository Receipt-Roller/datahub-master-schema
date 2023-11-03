using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Creative Work
    /// </summary>
    public class CreativeWork
    {
        public string About { get; set; } 
        public string Abstract { get; set; }
        public string AccessMode { get; set; }
        public List<string> AccessModeSufficient { get; set; }
        public string AccessibilityAPI { get; set; }
        public string AccessibilityControl { get; set; }
        public string AccessibilityFeature { get; set; }
        public string AccessibilityHazard { get; set; }
        public string AccessibilitySummary { get; set; }
    
        public List<Person> AccountablePersons { get; set; }
    }
}
