using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class SupplierModel
    {
        public Guid SupplierID { get; set; }

        [StringLength(10, ErrorMessage = "Limit Supplier Code to 10 characters.")]
        public string SupplierCode { get; set; }

        [StringLength(100, ErrorMessage = "Limit Supplier Name to 100 characters.")]
        public string SupplierName { get; set; }

        [StringLength(100, ErrorMessage = "Limit Contact Person to 100 characters.")]
        public string ContactPerson { get; set; }

        [StringLength(50, ErrorMessage = "Limit Street Number to 50 characters.")]
        public string StreetNo { get; set; }

        [StringLength(50, ErrorMessage = "Limit Barangay to 50 characters.")]
        public string Barangay { get; set; }

        [StringLength(50, ErrorMessage = "Limit FTown District to 50 characters.")]
        public string TownDistrict { get; set; }

        [StringLength(50, ErrorMessage = "Limit City Province to 50 characters.")]
        public string CityProvince { get; set; }

        [StringLength(10, ErrorMessage = "Limit Zip Code to 10 characters.")]
        public string ZipCode { get; set; }

        [StringLength(50, ErrorMessage = "Limit Phone Number to 50 characters.")]
        public string PhoneNo { get; set; }

        [StringLength(15, ErrorMessage = "Limit Mobile Number to 15 characters.")]
        public string MobileNo { get; set; }

        [StringLength(50, ErrorMessage = "Limit Fax Number to 50 characters.")]
        public string FaxNo { get; set; }

        public int? PaymentTerm { get; set; }

        [StringLength(20, ErrorMessage = "Limit TIN Number to 20 characters.")]
        public string TIN { get; set; }

        [StringLength(50, ErrorMessage = "Limit Email Address to 50 characters.")]
        public string EmailAddress { get; set; }

        [StringLength(500, ErrorMessage = "Limit Remarks to 500 characters.")]
        public string Remarks { get; set; }

        public double? VATAmount { get; set; }

        public double? VATPercent { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
