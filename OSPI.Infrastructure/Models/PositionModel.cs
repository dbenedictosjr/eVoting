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
        [Display(Name = "Position")]
        public string PositionName { get; set; }

        [Required]
        [Display(Name = "Slots")]
        public int RequiredCandidates { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Qualifications { get; set; }

        [Required]
        public Guid ElectionID { get; set; }

        [Display(Name = "Ref. No.")]
        public string RefCode { get; set; }

        public string Description { get; set; }

        [Display(Name = "Reg. Start Date")]
        [DataType(DataType.Date)]
        public DateTime RegStartDate { get; set; }

        [Display(Name = "Reg. End Date")]
        [DataType(DataType.Date)]
        public DateTime RegEndDate { get; set; }

        [Display(Name = "Voting Start Date")]
        [DataType(DataType.Date)]
        public DateTime VotingStartDate { get; set; }

        [Display(Name = "Voting End Date")]
        [DataType(DataType.Date)]
        public DateTime VotingEndDate { get; set; }

        public byte[] RowVersion { get; set; }
    }

    public class JPositionModel
    {
        public string PositionName { get; set; }

        public int RequiredCandidates { get; set; }

        public string Qualifications { get; set; }
    }
}
