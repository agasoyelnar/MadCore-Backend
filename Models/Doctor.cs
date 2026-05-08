using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MadCore.Models
{
    public class Doctor:BaseEntity
    {

        public int DepartmentId { get; set; }

        public int SpecializationId { get; set; }

        public string Bio { get; set; }

        public string PhotoUrl { get; set; }

        public int? ExperienceYears { get; set; }

        public Department Department { get; set; }

        public  Specialization Specialization { get; set; }
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}