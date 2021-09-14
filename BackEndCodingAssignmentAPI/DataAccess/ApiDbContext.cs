using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BackEndCodingAssignmentAPI.DataAccess
{
    public class ApiDbContext : DbContext
    {
        public DbSet<ApplicationSetting> ApplicationSettings { get; set; }
        public DbSet<ApplicationEventLog> ApplicationEventLogs { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public void InitialiseDatabase()
        {
            if (!ApplicationSettings.Any())
            {
                ApplicationSettings.Add(new ApplicationSetting()
                {
                    HeaderVerificationKey = $"Application verified: {Guid.NewGuid()}"
                });
                SaveChanges();
            }

            if(!ApplicationEventLogs.Any())
            {
                for (var i = 100; i>0;i--)
                {
                    ApplicationEventLogs.Add(
                        new ApplicationEventLog()
                        {
                            Message = "Request made successfully.",
                            IsError = false,
                            Timestamp = DateTimeOffset.UtcNow.AddDays(i * -1)
                        });
                    ApplicationEventLogs.Add(
                        new ApplicationEventLog()
                        {
                            Message = "Object reference not set to an instance of an object.",
                            IsError = true,
                            Timestamp = DateTimeOffset.UtcNow.AddDays(i * -1)
                        });
                    ApplicationEventLogs.Add(
                        new ApplicationEventLog()
                        {
                            Message = "Test run successful.",
                            IsError = false,
                            Timestamp = DateTimeOffset.UtcNow.AddDays(i * -1)
                        });
                }
                SaveChanges();
            }
        }
    }
}
