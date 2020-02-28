using System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace System.Domain.Entities
{
    public class RoleEntity : IAuditableEntity
    {
        [Key]
        public Guid RoleID { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string RoleName { get; set; }

        [Column(TypeName = "VARCHAR(250)")]
        public string Description { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}