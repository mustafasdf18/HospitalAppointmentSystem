using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Project.Models
{
    public class AppointmentSlot
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public string? PatientName {  set; get; }

        public string? Text => PatientName;

        [JsonPropertyName("patient")]
        public string? PatientId { set; get; }

        public string Status { get; set; } = "free";

    }
    
    public class DoctorDbContext : DbContext
    {

        public DbSet<AppointmentSlot> Appointments { get; set; }

        // DoctorDbContext
        public DoctorDbContext(DbContextOptions<DoctorDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
