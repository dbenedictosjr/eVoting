using System;
using System.ComponentModel.DataAnnotations;

namespace Online_Store.Infrastructure.Models
{
    public class RTPModel
    {
        public Guid RTPID { get; set; }

        [StringLength(30, ErrorMessage = "Limit Request To Purchase Number to 30 characters.")]
        public string RTPNo { get; set; }

        public DateTime? TranDate { get; set; }

        public Guid? SupplierID { get; set; }

        [StringLength(500, ErrorMessage = "Limit Remarks to 500 characters.")]
        public string Remarks { get; set; }

        public Guid? StatusID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
