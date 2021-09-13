using BackEndCodingAssignmentAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BackEndCodingAssignmentAPI.Services
{
    public class ApplicationSettingsService : IApplicationSettingsService
    {
        private readonly ApiDbContext dbContext;

        public ApplicationSettingsService(ApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ApplicationSetting> GetApplicationSettings()
        {
            return await this.dbContext.ApplicationSettings.FirstOrDefaultAsync();
        }
    }
}
