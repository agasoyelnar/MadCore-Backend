namespace MadCore.Models
{
    public class Specialization:BaseEntity
    {
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }= new List<Doctor>();
    }
}
