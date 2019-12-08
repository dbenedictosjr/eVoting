using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class ProductModel
    {
        [Required]
        public Guid Product_ID { get; set; }

        [StringLength(10, ErrorMessage = "Limit Code to 10 characters.")]
        public string Product_Code { get; set; }

        [StringLength(40, ErrorMessage = "Limit Short Description to 40 characters.")]
        public string Short_Description { get; set; }

        [StringLength(100, ErrorMessage = "Limit Long Description to 100 characters.")]
        public string Long_Description { get; set; }

        [Required]
        public Guid Category_ID { get; set; }

        [Required]
        public long UOM_ID { get; set; }

        [Required]
        public double Unit_Qty { get; set; }

        [Required]
        public double Minimum_tock { get; set; }

        [Required]
        public double Maximum_Stock { get; set; }

        [Required]
        public double Product_Cost { get; set; }

        [Required]
        public double? Markup_Amount { get; set; }

        [Required]
        public double? Markup_Percentage { get; set; }

        [Required]
        public double Product_Price { get; set; }

        [Required]
        public bool? Vatable { get; set; }

        [StringLength(20, ErrorMessage = "Limit Barcode to 20 characters.")]
        public string Barcode { get; set; }

        [Required]
        public double Stock { get; set; }

        [Required]
        public bool? Active { get; set; }

        public byte[] RowVersion { get; set; }
    }
}