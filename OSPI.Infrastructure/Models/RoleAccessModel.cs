using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class RoleAccessModel
    {
        [Required]
        public Guid RoleAccessID { get; set; }

        public Guid RoleID { get; set; }

        [Display(Name = "Role")]
        public string RoleName { get; set; }

        [Required]
        public Guid ModuleID { get; set; }

        [Display(Name = "Module")]
        public string ModuleName { get; set; }

        [Required]
        [Display(Name = "Can Add")]
        public bool CanAdd { get; set; }

        [Required]
        [Display(Name = "Can Edit")]
        public bool CanEdit { get; set; }

        [Required]
        [Display(Name = "Can Delete")]
        public bool CanDelete { get; set; }

        [Required]
        [Display(Name = "Can View")]
        public bool CanView { get; set; }

        [Required]
        [Display(Name = "Can Print")]
        public bool CanPrint { get; set; }

        public byte[] RowVersion { get; set; }
    }
}