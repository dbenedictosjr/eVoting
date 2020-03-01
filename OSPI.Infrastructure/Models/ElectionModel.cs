using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Infrastructure.Models
{
   public class ElectionModel
    {
        public Guid ElectionId { get; set; }

        [Required]
        [Display(Name = "Date Electiond")]
        [DataType(DataType.Date)]
        public DateTime DateElectiond { get; set; }

        [Required]
        public Guid MemberId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Display(Name = "Member")]
        public string FullName { get { return this.FirstName + ' ' + this.LastName; } }

        [Required]
        public Guid BallotId { get; set; }

        [Display(Name = "Ballot")]
        public string Description { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
