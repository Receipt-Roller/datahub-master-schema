using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Represents a log entry for inventory, inheriting common properties from the Thing class.
    /// This class can be used to track inventory details such as quantities, locations, and dates.
    /// </summary>
    public class Inventory : Thing
    {
        /// <summary>
        /// Initializes a new instance of the InventoryLog class with a specific identifier and name.
        /// </summary>
        /// <param name="identifier">A unique identifier for the inventory log entry.</param>
        /// <param name="name">The name of the inventory log entry.</param>
        public Inventory(string identifier, string name) : base(identifier, name)
        {
        }

        /// <summary>
        /// Parameterless constructor for deserialization purposes.
        /// </summary>
        public Inventory() : base()
        {
            // Initialization specific to InventoryLog, if necessary
        }

        /// <summary>
        /// The date and time as of which the inventory information is accurate.
        /// Nullable to allow for situations where the date is unknown or not applicable.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? AsOf { get; set; }

        /// <summary>
        /// The product associated with this inventory log entry.
        /// Nullable if the product information is not available or not applicable.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Product? Product { get; set; }

        /// <summary>
        /// The location where the inventory is stored or tracked.
        /// Nullable if the location is not specified or not relevant.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Place? Location { get; set; }

        /// <summary>
        /// The quantity of the product in inventory.
        /// Nullable if the quantity is not known or not applicable.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public QuantitativeValue? Quantity { get; set; }

        /// <summary>
        /// The quantity of the product on backorder.
        /// Nullable if there are no backorders or this information is not relevant.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public QuantitativeValue? BackOrder { get; set; }

        /// <summary>
        /// The lead time for replenishing the product.
        /// Nullable if lead time is not known or not applicable.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public QuantitativeValue? LeadTime { get; set; }

        /// <summary>
        /// The number of pending orders for the product.
        /// Nullable if there are no pending orders or this information is not relevant.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public QuantitativeValue? PendingOrders { get; set; }

        /// <summary>
        /// Days Sales of Inventory (DSI), a measure of how long it would take to sell the current inventory.
        /// Nullable if DSI is not calculated or not applicable.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public QuantitativeValue? Dsi { get; set; }
    }

    /// <summary>
    /// Represents a transaction within an inventory system, inheriting common properties from the Thing class.
    /// This class captures details about inventory movements such as stock additions, sales, or returns.
    /// </summary>
    public class InventoryTransaction : Thing
    {
        /// <summary>
        /// Initializes a new instance of the InventoryTransaction class without any arguments.
        /// </summary>
        public InventoryTransaction() : base()
        {
            // Initialization, if necessary
        }

        /// <summary>
        /// Initializes a new instance of the InventoryTransaction class with a specific identifier and name.
        /// </summary>
        /// <param name="identifier">A unique identifier for the inventory transaction.</param>
        /// <param name="name">The name of the inventory transaction.</param>
        public InventoryTransaction(string identifier, string name) : base(identifier, name)
        {
            // Initialization with specific identifier and name
        }

        /// <summary>
        /// The type of transaction, such as "Stock Addition", "Sale", "Return", etc.
        /// This field can be used to categorize the transaction within the inventory system.
        /// </summary>
        public string? TransactionType { get; set; }

        /// <summary>
        /// The date and time when the transaction occurred.
        /// This information is crucial for tracking the timing of inventory changes.
        /// </summary>
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// The product involved in the transaction.
        /// This property links the transaction to a specific product in the inventory.
        /// </summary>
        public Product? Product { get; set; }

        /// <summary>
        /// The quantity of the product involved in the transaction.
        /// This field represents how much of the product was involved in the transaction.
        /// </summary>
        public QuantitativeValue? Quantity { get; set; }

        /// <summary>
        /// Additional details or notes about the transaction.
        /// This field can be used to store extra information that might be relevant to the transaction.
        /// </summary>
        public string? Notes { get; set; }

        /// <summary>
        /// The source or destination of the product, depending on the transaction type.
        /// For instance, this could be the supplier for a stock addition or the customer for a sale.
        /// </summary>
        public string? SourceOrDestination { get; set; }

        /// <summary>
        /// The person who handled the transaction.
        /// This property can be used to track who was responsible for or involved in the transaction.
        /// </summary>
        public Person? HandledBy { get; set; }

        // Additional properties and methods as necessary...
    }

}
