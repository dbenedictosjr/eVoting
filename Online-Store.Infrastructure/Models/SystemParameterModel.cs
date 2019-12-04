using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class SystemParameterModel
    {
        public Guid SysID { get; set; }

        [StringLength(10, ErrorMessage = "Limit System Code to 10 characters.")]
        public string SysCode { get; set; }

        [StringLength(1000, ErrorMessage = "Limit System Name to 1000 characters.")]
        public string SysName { get; set; }

        public Guid? SysNo { get; set; }

        [StringLength(1000, ErrorMessage = "Limit System Description to 1000 characters.")]
        public string SysDescription { get; set; }

        public double? SysAmount { get; set; }

        [StringLength(10, ErrorMessage = "Limit System Prefix to 10 characters.")]
        public string SysPrefix { get; set; }

        public bool? SysPrefixYear { get; set; }

        public bool? SysPrefixMonth { get; set; }

        [StringLength(10, ErrorMessage = "Limit System Suffix to 10 characters.")]
        public string SysSuffix { get; set; }

        public bool? SysSuffixYear { get; set; }

        public bool? SysSuffixMonth { get; set; }

        [StringLength(10, ErrorMessage = "Limit System Reset Scheme to 10 characters.")]
        public string SysResetScheme { get; set; }

        public DateTime? SysResetDate { get; set; }

        public Guid? CheckedBy { get; set; }

        public Guid? ApprovedBy { get; set; }

        public Guid? NotedBy { get; set; }

        public bool? SysList { get; set; }

        public Guid? CentreID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
