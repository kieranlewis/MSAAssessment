using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MSAAssessment.Models;

namespace MSAAssessment.DAL
{
    public class SchoolContext
    {
        public SchoolContext()
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}