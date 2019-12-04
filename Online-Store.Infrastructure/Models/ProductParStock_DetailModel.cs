using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class ProductParStock_DetailModel
    {
        public Guid ParStockDetailID { get; set; }

        public Guid? ParStockID { get; set; }

        public Guid? ProductID { get; set; }

        public double? MaximumStock { get; set; }

        public double? MinimumStock { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
