using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class StoreModel
    {
        public Guid StoreID { get; set; }

        [StringLength(20, ErrorMessage = "Limit Store Code to 20 characters.")]
        public string StoreCode { get; set; }

        [StringLength(50, ErrorMessage = "Limit Store Name to 50 characters.")]
        public string StoreName { get; set; }

        [StringLength(50, ErrorMessage = "Limit Operator to 50 characters.")]
        public string OperatedBy { get; set; }

        [StringLength(40, ErrorMessage = "Limit Address1 to 40 characters.")]
        public string Address1 { get; set; }

        [StringLength(40, ErrorMessage = "Limit Address2 to 40 characters.")]
        public string Address2 { get; set; }

        [StringLength(15, ErrorMessage = "Limit Phone Number to 15 characters.")]
        public string Phone { get; set; }

        [StringLength(15, ErrorMessage = "Limit Mobile Number to 15 characters.")]
        public string Mobile { get; set; }

        [StringLength(20, ErrorMessage = "Limit TIN Number to 20 characters.")]
        public string TIN { get; set; }

        [StringLength(20, ErrorMessage = "Limit Permit Number to 20 characters.")]
        public string PermitNo { get; set; }

        [StringLength(20, ErrorMessage = "Limit MIN Number to 20 characters.")]
        public string MIN_No { get; set; }

        [StringLength(30, ErrorMessage = "Limit Serial Number to 30 characters.")]
        public string SerialNo { get; set; }

        public DateTime? SH_Start { get; set; }

        public DateTime? SH_End { get; set; }

        [StringLength(50, ErrorMessage = "Limit Email Address to 50 characters.")]
        public string EmailAddress { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
