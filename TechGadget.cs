using System;

namespace TechGadgetCollection
{
    /// <summary>
    /// Represents a tech gadget in the collection, inheriting from CollectionItem
    /// </summary>
    public class TechGadget : CollectionItem
    {
        // Custom properties specific to tech gadgets (based on your form controls)
        public string Manufacturer { get; set; }
        public string ModelNumber { get; set; }
        public string SerialNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string FirmwareVersion { get; set; }
        public bool IsWorkingCondition { get; set; }
        public bool IsUnderWarranty { get; set; }
        public DateTime WarrantyUntil { get; set; }

        // Default constructor - calls base constructor with required parameters
        public TechGadget() : base("", "", "")
        {
            Manufacturer = string.Empty;
            ModelNumber = string.Empty;
            SerialNumber = string.Empty;
            PurchaseDate = DateTime.Now;
            FirmwareVersion = string.Empty;
            IsWorkingCondition = true;
            IsUnderWarranty = true;
            WarrantyUntil = DateTime.Now.AddYears(1);
        }

        // Constructor with basic parameters - calls base constructor with required parameters
        public TechGadget(string name, string description)
            : base(name, description, DateTime.Now.ToString("yyyy-MM-dd"))
        {
            Manufacturer = string.Empty;
            ModelNumber = string.Empty;
            SerialNumber = string.Empty;
            PurchaseDate = DateTime.Now;
            FirmwareVersion = string.Empty;
            IsWorkingCondition = true;
            IsUnderWarranty = true;
            WarrantyUntil = DateTime.Now.AddYears(1);
        }

        // Constructor with all parameters - calls base constructor with required parameters
        public TechGadget(string name, string description, string manufacturer,
                         string modelNumber, string serialNumber, DateTime purchaseDate)
            : base(name, description, purchaseDate.ToString("yyyy-MM-dd"))
        {
            Manufacturer = manufacturer;
            ModelNumber = modelNumber;
            SerialNumber = serialNumber;
            PurchaseDate = purchaseDate;
            FirmwareVersion = string.Empty;
            IsWorkingCondition = true;
            IsUnderWarranty = true;
            WarrantyUntil = DateTime.Now.AddYears(1);
        }

        // Full constructor with all tech gadget properties
        public TechGadget(string name, string description, string manufacturer,
                         string modelNumber, string serialNumber, DateTime purchaseDate,
                         string firmwareVersion, bool isWorkingCondition,
                         bool isUnderWarranty, DateTime warrantyUntil)
            //fix parameters order yyyy to m d fromat 
            : base(name, DateTime.Now.ToString("M/d/yyyy"), description) 
        {
            Manufacturer = manufacturer;
            ModelNumber = modelNumber;
            SerialNumber = serialNumber;
            PurchaseDate = purchaseDate;
            FirmwareVersion = firmwareVersion;
            IsWorkingCondition = isWorkingCondition;
            IsUnderWarranty = isUnderWarranty;
            WarrantyUntil = warrantyUntil;
        }

        /// <summary>
        /// Override GetSummary method to provide meaningful summary for tech gadgets
        /// This method MUST be overridden as required by the assignment
        /// </summary>
        /// <returns>A comprehensive summary of the tech gadget</returns>
        public override string GetSummary()
        {
            string conditionStatus = IsWorkingCondition ? "Working" : "Broken";
            string warrantyStatus = IsUnderWarranty ? "Under Warranty" : "Out of Warranty";

            return $"Tech Gadget: {Name} by {Manufacturer} " +
                   $"(Model: {ModelNumber}, S/N: {SerialNumber}) - " +
                   $"Purchased: {PurchaseDate:MM/dd/yyyy}, " +
                   $"Condition: {conditionStatus}, " +
                   $"Warranty: {warrantyStatus} until {WarrantyUntil:MM/dd/yyyy}. " +
                   $"Description: {Description}";
        }
    }
}