using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCodingAssignmentAPI.DataAccess
{
    public class ApplicationEventLog
    {
        [Key]
        public int Id { get; set; }
        public bool IsError { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public string Message { get; set; }
    }
}
