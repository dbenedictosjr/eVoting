using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class EmployeeModel
    {
        public Guid EmployeeID { get; set; }

        public Guid? StoreID { get; set; }

        [StringLength(100, ErrorMessage = "Limit Employee Name to 100 characters.")]
        public string EmployeeName { get; set; }

        [StringLength(50, ErrorMessage = "Limit Employee Position to 50 characters.")]
        public string EmpPosition { get; set; }

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

        [StringLength(10, ErrorMessage = "Limit Home Zip Code to 10 characters.")]
        public string HomeZipCode { get; set; }

        [StringLength(15, ErrorMessage = "Limit Home Phone Number to 15 characters.")]
        public string HomePhoneNo { get; set; }

        [StringLength(100, ErrorMessage = "Limit Email Address to 100 characters.")]
        public string EmailAddress { get; set; }

        [StringLength(6, ErrorMessage = "Limit Gender to 6 characters.")]
        public string Gender { get; set; }

        [StringLength(10, ErrorMessage = "Limit Civil Status to 10 characters.")]
        public string CivilStatus { get; set; }

        [StringLength(15, ErrorMessage = "Limit Mobile Number to 15 characters.")]
        public string MobileNo { get; set; }

        public double? SCMax { get; set; }

        [StringLength(10, ErrorMessage = "Limit TIN to 10 characters.")]
        public string TIN { get; set; }

        [StringLength(12, ErrorMessage = "Limit SSS to 12 characters.")]
        public string SSS { get; set; }

        [StringLength(12, ErrorMessage = "Limit HDMF to 12 characters.")]
        public string HDMF { get; set; }

        [StringLength(12, ErrorMessage = "Limit PHILHEALTH to 12 characters.")]
        public string PHILHEALTH { get; set; }

        [StringLength(12, ErrorMessage = "Limit Senior Citizen Scheme to 12 characters.")]
        public string SCScheme { get; set; }

        public DateTime? SCReset { get; set; }

        public double? Rate { get; set; }

        [StringLength(10, ErrorMessage = "Limit Employee Number to 10 characters.")]
        public string EmployeeNo { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
