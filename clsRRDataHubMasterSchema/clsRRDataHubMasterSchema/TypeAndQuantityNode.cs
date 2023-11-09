using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    public class TypeAndQuantityNode : Thing
    {
        public TypeAndQuantityNode(string identifier, string name) : base(identifier, name)
        {
        }

        public int AmountOfThisGood { get; set; }
        public string BusinessFunction { get; set; }
        public string TypeOfGood { get; set; }
        public string UnitCode { get; set; }
        public string UnitText { get; set; }
    }
}
