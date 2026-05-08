using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MadCore.Models
{
    public class Department:BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<Service> Services { get; set; } = new List<Service>();
    }
}