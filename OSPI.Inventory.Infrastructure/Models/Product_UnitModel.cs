using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class Product_UnitModel
    {
        public Guid ProductUnitID { get; set; }

        [StringLength(50, ErrorMessage = "Limit Product Unit Description to 50 characters.")]
        public string ProductUnitDescription { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
