using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class SystemParameterEntity : IAuditableEntity
    {
        [Key]
        public Guid SysId { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string SysCode { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string SysName { get; set; }

        public Guid? SysNo { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string SysDescription { get; set; }

        public double? SysAmount { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SysPrefix { get; set; }

        public bool? SysPrefixYear { get; set; }

        public bool? SysPrefixMonth { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SysSuffix { get; set; }

        public bool? SysSuffixYear { get; set; }

        public bool? SysSuffixMonth { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SysResetScheme { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? SysResetDate { get; set; }

        public Guid? CheckedBy { get; set; }

        public Guid? ApprovedBy { get; set; }

        public Guid? NotedBy { get; set; }

        public bool? SysList { get; set; }

        public Guid? CentreId { get; set; }

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
