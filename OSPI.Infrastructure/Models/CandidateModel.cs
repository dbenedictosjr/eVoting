using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
   public class CandidateModel
    {
        [Required]
        public Guid CandidateId { get; set; }

        [Required]
        public Guid PositionId { get; set; }

        [Display(Name = "Position")]
        public string PositionName { get; set; }

        [Required]
        public Guid CandidateMemberId { get; set; }

        public string CandidateMemberNo { get; set; }

        public string CandidateFirstName { get; set; }

        public string CandidateLastName { get; set; }

        [Display(Name = "Candidate")]
        public string CandidateFullName { get { return this.CandidateFirstName + ' ' + this.CandidateLastName; } }

        public Guid NomineeMemberId { get; set; }

        public string NomineeFirstName { get; set; }

        public string NomineeLastName { get; set; }

        [Display(Name = "Nominee")]
        public string NomineeFullName { get { return this.NomineeFirstName + ' ' + this.NomineeLastName; } }

        public string Plataforma { get; set; }

        public string Status { get; set; }

        public byte[] RowVersion { get; set; }

        public ICollection<ElectionDetailModel> Votes { get; set; }

        public int TotalVotes { get {
                if (Votes != null)
                    return Votes.Count;
                else
                    return 0;
            } }
    }

    public class CCandidateModel
    {
        public Guid CandidateId { get; set; }

        public string CandidateName { get; set; }
    }

}