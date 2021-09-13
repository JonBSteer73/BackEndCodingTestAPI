using BackEndCodingAssignmentAPI.DataAccess;
using System.Threading.Tasks;

namespace BackEndCodingAssignmentAPI.Services
{
    public interface IApplicationSettingsService
    {
        Task<ApplicationSetting> GetApplicationSettings();
    }
}
