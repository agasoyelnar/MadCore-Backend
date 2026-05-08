using MadCore.Models;

public class AppUser:BaseEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Phone { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public Doctor? Doctor { get; set; }
    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    public ICollection<Testimonial> Testimonials { get; set; } = new List<Testimonial>();
}

