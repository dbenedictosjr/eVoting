using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class SupplierEntity : IAuditableEntity
    {
        [Key]
        public Guid SupplierId { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SupplierCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string SupplierName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ContactPerson { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string StreetNo { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Barangay { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string TownDistrict { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string CityProvince { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string ZipCode { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string PhoneNo { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string MobileNo { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string FaxNo { get; set; }

        public int? PaymentTerm { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string TIN { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string EmailAddress { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string Remarks { get; set; }

        public double? VATAmount { get; set; }

        public double? VATPercent { get; set; }

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
