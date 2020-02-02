using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class RoleEntity : IAuditableRepository
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

        public virtual ICollection<RoleAccessEntity> RoleAccesses { get; set; }
    }
}