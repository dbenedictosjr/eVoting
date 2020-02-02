using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class BallotModel
    {
        [Key]
        public Guid BallotID { get; set; }

        public DateTime RegStartDate { get; set; }

        public DateTime RegEndDate { get; set; }

        public DateTime VoteStartDate { get; set; }

        public DateTime VoteEndDate { get; set; }

        public Guid PositionID { get; set; }

        public byte[] RowVersion { get; set; }
        
        public string Position { get; set; }
    }
}
