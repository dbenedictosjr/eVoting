using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
   public class CandidateModel
    {
        [Required]
        public Guid CandidateID { get; set; }

        [Required]
        public Guid PositionID { get; set; }

        [Display(Name = "Position")]
        public string PositionName { get; set; }

        [Required]
        public Guid CandidateMemberID { get; set; }

        public string CandidateFirstName { get; set; }

        public string CandidateLastName { get; set; }

        [Display(Name = "Candidate")]
        public string CandidateFullName { get { return this.CandidateFirstName + ' ' + this.CandidateLastName; } }

        public Guid NomineeMemberID { get; set; }

        public string NomineeFirstName { get; set; }

        public string NomineeLastName { get; set; }

        [Display(Name = "Nominee")]
        public string NomineeFullName { get { return this.NomineeFirstName + ' ' + this.NomineeLastName; } }

        public string Plataforma { get; set; }

        public string Status { get; set; }

        public byte[] RowVersion { get; set; }
    }
}