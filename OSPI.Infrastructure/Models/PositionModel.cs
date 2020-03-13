using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class PositionModel
    {
        [Required]
        public Guid PositionId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Limit Description to 30 characters.")]
        [Display(Name = "Position")]
        public string PositionName { get; set; }

        [Required]
        [Display(Name = "Minumum Votes")]
        public int MinimumRequiredVotes { get; set; }

        [Required]
        [Display(Name = "Maximum Votes")]
        public int MaximumRequiredVotes { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Qualifications { get; set; }

        [Required]
        public Guid BallotId { get; set; }

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

        public int MinimumRequiredVotes { get; set; }

        public int MaximumRequiredVotes { get; set; }

        public string Qualifications { get; set; }

    }

    public class CPositionModel
    {
        public string PositionId { get; set; }

        public string PositionName { get; set; }

        public int MinimumVotes { get; set; }

        public int MaximumVotes { get; set; }

        public ICollection<CCandidateModel> Candidates { get; set; }
    }
    public class ElecctioDataModel
    {
        public string PositionName { get; set; }
        public string PositionId { get; set; } 
        public ICollection<CandidateDataModel> Candidates { get; set; }
    }
    public class CandidateDataModel
    {
        public string CandidateId { get; set; }

        public string CandidateName { get; set; }
        public string MemberNumber { get; set; }
        public string MemberId { get; set; }
    }
}
