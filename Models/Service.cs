using System.ComponentModel.DataAnnotations;

namespace MadCore.Models
{
    public class Service:BaseEntity
    {

        
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }

        public Department Department { get; set; }
    }
}