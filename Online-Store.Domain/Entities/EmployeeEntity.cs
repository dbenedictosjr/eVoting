using Online_Store.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class EmployeeEntity : IAuditableRepository
    {
        [Key]
        public Guid EmployeeID { get; set; }

        public Guid? StoreID { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string EmployeeName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string EmpPosition { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? EntryDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? BirthDate { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string HomeNoStreet { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string HomeBarangay { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string HomeTownDistrict { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string HomeCityProvince { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string HomeZipCode { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string HomePhoneNo { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string EmailAddress { get; set; }

        [Column(TypeName = "varchar(6)")]
        public string Gender { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string CivilStatus { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string MobileNo { get; set; }

        public double? SCMax { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string TIN { get; set; }

        [Column(TypeName = "varchar(12)")]
        public string SSS { get; set; }

        [Column(TypeName = "varchar(12)")]
        public string HDMF { get; set; }

        [Column(TypeName = "varchar(12)")]
        public string PHILHEALTH { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string SCScheme { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? SCReset { get; set; }

        public double? Rate { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string EmployeeNo { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}
