using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class StatusModel
    {
        public Guid StatusID { get; set; }

        [StringLength(25, ErrorMessage = "Limit Status Description to 25 characters.")]
        public string StatusDescription { get; set; }

        [StringLength(25, ErrorMessage = "Limit Module to 25 characters.")]
        public string Module { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
