using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class DeletedRecordsModel
    {
        public Guid DeletedID { get; set; }

        public Guid? PrimaryID { get; set; }

        [StringLength(255, ErrorMessage = "Limit Source Table to 255 characters.")]
        public string SourceTable { get; set; }

        public DateTime? DateDeleted { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
