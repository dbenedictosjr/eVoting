using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class VoteModel
    {
        [Required]
        public Guid VoteID { get; set; }

        [Required]
        public Guid CandidateID { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
