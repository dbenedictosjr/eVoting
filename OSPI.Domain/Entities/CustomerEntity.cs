using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class CustomerEntity : IAuditableRepository
    {
        [Key]
        public Guid CustomerID { get; set; }

        public Guid? StoreID { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string CustomerNo { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string CustomerName { get; set; }

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

        [Column(TypeName = "varchar(100)")]
        public string LandMark { get; set; }

        [Column(TypeName = "varchar(6)")]
        public string Gender { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string CivilStatus { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string MobileNo { get; set; }

        public double? DiscountAmount { get; set; }

        public double? DiscountPercent { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string CustomerType { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string CardNumber { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }

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
