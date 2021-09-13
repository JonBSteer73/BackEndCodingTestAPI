using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BackEndCodingAssignmentAPI.DataAccess
{
    public class ApiDbContext : DbContext
    {
        public DbSet<ApplicationSetting> ApplicationSettings { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public void IniitialiseDatabase()
        {
            if (!ApplicationSettings.Any())
            {
                ApplicationSettings.Add(new ApplicationSetting()
                {
                    HeaderVerificationKey = $"Application verified: {Guid.NewGuid()}"
                });
                SaveChanges();
            }
        }
    }
}
