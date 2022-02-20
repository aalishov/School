using System;

namespace P07_MessageAPI.Data.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public string User { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
