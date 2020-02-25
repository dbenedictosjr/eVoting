using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class SystemUserEntity : IAuditableEntity
    {
        [Key]
        public Guid UserID { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string UserCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string UserName { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string UserPassword { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? UserValidity { get; set; }

        public bool? UserLocked { get; set; }

        public bool? UserReset { get; set; }

        public Guid? LevelID { get; set; }

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
