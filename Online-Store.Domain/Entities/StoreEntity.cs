using Online_Store.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class StoreEntity : IAuditableRepository
    {
        [Key]
        public Guid StoreID { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string StoreCode { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string StoreName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string OperatedBy { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string Address1 { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string Address2 { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Phone { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Mobile { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string TIN { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string PermitNo { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string MIN_No { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string SerialNo { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? SH_Start { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? SH_End { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string EmailAddress { get; set; }

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
