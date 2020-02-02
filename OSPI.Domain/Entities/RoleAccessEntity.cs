using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class RoleAccessEntity : IAuditableEntity
    {
        [Key]
        public Guid RoleAccessID { get; set; }

        public Guid RoleID { get; set; }

        public Guid ModuleID { get; set; }

        public bool CanAdd { get; set; }

        public bool CanEdit { get; set; }

        public bool CanDelete { get; set; }

        public bool CanView { get; set; }

        public bool CanPrint { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("ModuleID")]
        public virtual ModuleEntity Module { get; set; }

        [ForeignKey("RoleID")]
        public virtual RoleEntity Role { get; set; }
    }
}