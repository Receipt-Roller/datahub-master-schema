using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Represents specific property values often associated with products or services.
    /// </summary>
    public class PropertyValue : Thing
    {
        // Constructor with parameters to initialize a PropertyValue object with an identifier and name.
        public PropertyValue(string identifier, string name) : base(identifier, name)
        {
        }

        // Default parameterless constructor for deserialization purposes.
        // Allows JSON deserializer to construct an object without explicitly providing identifier and name.
        public PropertyValue() : base()
        {
            // Initialization specific to PropertyValue, if necessary, can be placed here.
        }

        // Nullable long property to store the maximum value of the property.
        // It will be ignored during serialization when its value is null.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? MaxValue { get; set; }

        // Nullable string property to store the measurement method.
        // It will be ignored during serialization when its value is null.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? MeasurementMethod { get; set; }

        // Nullable string property to store the measurement technique.
        // It will be ignored during serialization when its value is null.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? MeasurementTechnique { get; set; }

        // Nullable long property to store the minimum value of the property.
        // It will be ignored during serialization when its value is null.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? MinValue { get; set; }

        // Nullable string property to store the ID of the property.
        // It will be ignored during serialization when its value is null.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PropertyId { get; set; }

        // Nullable string property to store the code of the unit of measurement.
        // It will be ignored during serialization when its value is null.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UnitCode { get; set; }

        // Nullable string property to store the text description of the unit of measurement.
        // It will be ignored during serialization when its value is null.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UnitText { get; set; }

        // Nullable long property to store the value of the property itself.
        // It will be ignored during serialization when its value is null.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? Value { get; set; }

        // Nullable string property to store a reference that helps interpret the property value.
        // It will be ignored during serialization when its value is null.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ValueReference { get; set; }
    }

}
