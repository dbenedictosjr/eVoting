using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class CustomerModel
    {
        public Guid CustomerID { get; set; }

        public Guid? StoreID { get; set; }

        [StringLength(10, ErrorMessage = "Limit Customer Number to 10 characters.")]
        public string CustomerNo { get; set; }

        [StringLength(200, ErrorMessage = "Limit Customer Name to 200 characters.")]
        public string CustomerName { get; set; }

        public DateTime? EntryDate { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(50, ErrorMessage = "Limit Home Number Street to 50 characters.")]
        public string HomeNoStreet { get; set; }

        [StringLength(50, ErrorMessage = "Limit Home Barangay to 50 characters.")]
        public string HomeBarangay { get; set; }

        [StringLength(50, ErrorMessage = "Limit Home Town District to 50 characters.")]
        public string HomeTownDistrict { get; set; }

        [StringLength(50, ErrorMessage = "Limit Home City Province to 50 characters.")]
        public string HomeCityProvince { get; set; }

        [StringLength(10, ErrorMessage = "Limit Home Zip Number to 10 characters.")]
        public string HomeZipCode { get; set; }

        [StringLength(15, ErrorMessage = "Limit Home Phone Number to 15 characters.")]
        public string HomePhoneNo { get; set; }

        [StringLength(100, ErrorMessage = "Limit Email Address to 100 characters.")]
        public string EmailAddress { get; set; }

        [StringLength(100, ErrorMessage = "Limit Landmark to 100 characters.")]
        public string LandMark { get; set; }

        [StringLength(6, ErrorMessage = "Limit Gender to 6 characters.")]
        public string Gender { get; set; }

        [StringLength(10, ErrorMessage = "Limit Civil Status to 10 characters.")]
        public string CivilStatus { get; set; }

        [StringLength(15, ErrorMessage = "Limit Mobile Number to 15 characters.")]
        public string MobileNo { get; set; }

        public double? DiscountAmount { get; set; }

        public double? DiscountPercent { get; set; }

        [StringLength(50, ErrorMessage = "Limit Customer Type to 50 characters.")]
        public string CustomerType { get; set; }

        [StringLength(15, ErrorMessage = "Limit Card Number to 15 characters.")]
        public string CardNumber { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
