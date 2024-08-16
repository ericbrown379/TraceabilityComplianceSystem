using System;

namespace TraceabilityComplianceSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string Status { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}