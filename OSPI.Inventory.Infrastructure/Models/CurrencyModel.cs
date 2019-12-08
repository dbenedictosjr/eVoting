using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class CurrencyModel
    {
        public Guid CurrencyID { get; set; }

        [StringLength(20, ErrorMessage = "Limit Currency Description to 20 characters.")]
        public string CurrecyDescription { get; set; }

        public double? CurrencyValue { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
