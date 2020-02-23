using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Infrastructure.Models
{
   public class VoteModel
    {
        public Guid VoteID { get; set; }

        [Required]
        [Display(Name = "Date Voted")]
        [DataType(DataType.Date)]
        public DateTime DateVoted { get; set; }

        [Required]
        public Guid MemberID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Display(Name = "Member")]
        public string FullName { get { return this.FirstName + ' ' + this.LastName; } }

        [Required]
        public Guid ElectionID { get; set; }

        [Display(Name = "Election")]
        public string Description { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
