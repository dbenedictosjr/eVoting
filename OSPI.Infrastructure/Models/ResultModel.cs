using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class ResultModel
    {
        [Required]
        public Guid ResultID { get; set; }

        [Required]
        public Guid VoteID { get; set; }

        [Required]
        public Guid MemberID { get; set; }

        [Required]
        public DateTime DateVoted { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
