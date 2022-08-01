using DoctorManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace DoctorManagement.EntityData
{
    public class DoctorContext:DbContext
    {
        public DoctorContext(DbContextOptions<DoctorContext>options):base(options)
        {

        }
        public DbSet<DoctorDescription> _doctorContext { get; set; }
    }
}
