using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
   public class CandidateModel
    {
        [Key]
        public Guid CandidateID { get; set; }

        public Guid CandidateMemberID { get; set; }

        public Guid BallotID { get; set; }

        public Guid NomineeMemberID { get; set; }

        public string Status { get; set; }

        public byte[] RowVersion { get; set; }

        public string CandidateName { get; set; }

        public string NomineeName { get; set; }

        public string PositionName { get; set; }
    }
}
