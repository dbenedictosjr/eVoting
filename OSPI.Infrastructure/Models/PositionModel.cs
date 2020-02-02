using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class PositionModel
    {
        [Required]
        public Guid PositionID { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Limit Description to 30 characters.")]
        public string Description { get; set; }

        [Required]
        public int RequiredCandidates { get; set; }

        [Required]
        public int Qualifications { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
