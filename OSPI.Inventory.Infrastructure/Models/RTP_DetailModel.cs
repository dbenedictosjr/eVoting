using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class RTP_DetailModel
    {
        public Guid RTPDetailID { get; set; }

        public Guid? RTPID { get; set; }

        public Guid? ProductID { get; set; }

        public double? Quantity { get; set; }

        public double? MaximumStock { get; set; }

        public double? Stock { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
