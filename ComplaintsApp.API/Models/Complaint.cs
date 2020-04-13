using System;

namespace ComplaintsApp.API.Models
{
    public class Complaint
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Detail { get; set; }
        public bool IsResolved { get; set; }
        public string ResolvedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}