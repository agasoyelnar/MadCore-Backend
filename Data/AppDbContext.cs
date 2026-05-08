using Microsoft.EntityFrameworkCore;
using MadCore.Models;

namespace MadCore.Data
{
    public class AppDbContext : DbContext  
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict); 
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
         

        //    modelBuilder.Entity<Doctor>()
        //        .HasOne(d => d.Department)
        //        .WithMany(dep => dep.Doctors)
        //        .HasForeignKey(d => d.DepartmentId);

        //    modelBuilder.Entity<Appointment>()
        //        .HasOne(a => a.User)
        //        .WithMany(u => u.Appointments)
        //        .HasForeignKey(a => a.UserId);

       

        //    modelBuilder.Entity<Appointment>()
        //        .HasOne(a => a.Department)
        //        .WithMany(dep => dep.Appointments)
        //        .HasForeignKey(a => a.DepartmentId);

        //    modelBuilder.Entity<Service>()
        //        .HasOne(s => s.Department)
        //        .WithMany(dep => dep.Services)
        //        .HasForeignKey(s => s.DepartmentId);

        //    modelBuilder.Entity<Testimonial>()
        //        .HasOne(t => t.Patient)
        //        .WithMany(u => u.Testimonials)
        //        .HasForeignKey(t => t.PatientId);
        //}
    }
}