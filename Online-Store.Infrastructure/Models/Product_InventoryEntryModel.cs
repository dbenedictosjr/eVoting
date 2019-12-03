using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class Product_InventoryEntryModel
    {
        public Guid ProductInventoryEntryID { get; set; }

        public DateTime? TranDate { get; set; }

        public DateTime? InvDate { get; set; }

        public Guid? StatusID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
