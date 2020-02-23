using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
   public class VoteDetailModel
    {
        [Required]
        public Guid VoteDetailID { get; set; }

        public Guid VoteID { get; set; }

        [Display(Name = "Election")]
        public string Description { get; set; }

        public Guid CandidateID { get; set; }

        [Display(Name = "Position")]
        public string PositionName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Display(Name = "Candidate")]
        public string FullName { get { return this.FirstName + ' ' + this.LastName; } }

        public string Plataforma { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
