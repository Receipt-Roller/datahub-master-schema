using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    // This class represents geographical coordinates, inheriting from the Thing class.
    // This inheritance allows it to include additional Thing-related information such as a name, description, etc.
    public class GeoCoordinates : Thing
    {
        // This constructor with parameters is used to create an instance of GeoCoordinates with a specific identifier and name.
        // It calls the base class constructor of Thing to initialize the inherited properties.
        public GeoCoordinates(string identifier, string name) : base(identifier, name)
        {
        }

        // A parameterless constructor is necessary for the deserialization process when using libraries such as Newtonsoft.Json or System.Text.Json.
        // It calls the base class constructor of Thing, which might perform necessary initializations.
        public GeoCoordinates() : base()
        {
        }

        // The Latitude property holds the north-south position of a point on the Earth's surface.
        // It is measured in degrees from the equator, with positive values indicating north and negative values indicating south.
        public double Latitude { get; set; }

        // The Longitude property holds the east-west position of a point on the Earth's surface.
        // It is measured in degrees from the Prime Meridian, with positive values indicating east and negative values indicating west.
        // The property name is in PascalCase, which is the standard naming convention for properties in C#.
        public double Longitude { get; set; }

        // Additional constructors, properties, methods, etc., may be inherited from Thing or defined here if necessary.
    }

}
