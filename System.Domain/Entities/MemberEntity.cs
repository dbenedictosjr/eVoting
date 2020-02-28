using System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace System.Domain.Entities
{
    public class MemberEntity : IAuditableEntity
    {
        [Key]
        public Guid MemberID { get; set; }

        [Column(TypeName = "CHAR(8)")]
        public string MemberNo { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime RegistrationDate { get; set; }

        [Column(TypeName = "CHAR(30)")]
        public string FirstName { get; set; }

        [Column(TypeName = "CHAR(30)")]
        public string MiddleName { get; set; }

        [Column(TypeName = "CHAR(30)")]
        public string LastName { get; set; }

        [Column(TypeName = "VARCHAR(150)")]
        public string HomeAddress { get; set; }

        [Column(TypeName = "CHAR(50)")]
        public string EmailAddress { get; set; }

        [Column(TypeName = "VARCHAR(15)")]
        public string PhoneNo { get; set; }

        [Column(TypeName = "VARCHAR(15)")]
        public string MobileNo { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime BirthDate { get; set; }

        [Column(TypeName = "FLOAT")]
        public double Capital { get; set; }

        [Column(TypeName = "CHAR(30)")]
        public string MemberStatus { get; set; }

        [Column(TypeName = "CHAR(30)")]
        public string CreditStatus { get; set; }

        [Column(TypeName = "CHAR(20)")]
        public string Password { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime DateHired { get; set; }

        [Column(TypeName = "FLOAT")]
        public double Salary { get; set; }

        [Column(TypeName = "CHAR(30)")]
        public string AccountNo { get; set; }

        public Guid RoleID { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("RoleID")]
        public virtual RoleEntity Role { get; set; }
    }
}
