using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Pagination model, this is for the pagination of the data
    /// Not part of schema.org but used for the pagination of the data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Pagination<T>
    {
        public int TotalPages { get; set; }
        public int TotalItems { get; set; }
        public string Keyword { get; set; }
        public string Sort { get; set; }
        public List<T> Items { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
    }
}
