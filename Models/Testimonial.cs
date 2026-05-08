using System;
using System.ComponentModel.DataAnnotations;

namespace MadCore.Models
{
    public class Testimonial:BaseEntity
    {

        public int PatientId { get; set; }

        public string Content { get; set; }

        public int Rating { get; set; }

        public string Profession { get; set; }

        public string AvatarUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow.AddHours(4);
        public AppUser Patient { get; set; } 

    }
}
