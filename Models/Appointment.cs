using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MadCore.Models
{
    public class Appointment:BaseEntity
    {
        public int UserId { get; set; }
        [ForeignKey(nameof(Doctor))]

        public int DoctorId { get; set; }

        public int DepartmentId { get; set; }

        public DateTime ApptDate { get; set; }

        public TimeSpan ApptTime { get; set; }

        public DateTime CreatedAt { get; set; }

        public Doctor Doctor { get; set; }
        public Department Department { get; set; }
        public AppUser User { get; set; }

    }
}