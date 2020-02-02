using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class RoleAccessModel
    {
        [Required]
        public Guid RoleAccessID { get; set; }

        public Guid RoleID { get; set; }

        [Required]
        public Guid ModuleID { get; set; }

        [Required]
        public string CanAdd { get; set; }

        [Required]
        public string CanEdit { get; set; }

        [Required]
        public string CanDelete { get; set; }

        [Required]
        public string CanView { get; set; }

        [Required]
        public string CanPrint { get; set; }

        public byte[] RowVersion { get; set; }

        public string ModuleName { get; set; }
    }
}