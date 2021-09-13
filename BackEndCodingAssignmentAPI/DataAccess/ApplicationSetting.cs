using System.ComponentModel.DataAnnotations;

namespace BackEndCodingAssignmentAPI.DataAccess
{
    public class ApplicationSetting
    {
        [Key]
        public int Id { get; set; }
        public string HeaderVerificationKey { get; set; }
    }
}
