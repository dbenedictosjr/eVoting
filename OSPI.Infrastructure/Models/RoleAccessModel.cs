using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class RoleAccessModel
    {
        [Required]
        public Guid RoleAccessId { get; set; }

        [Required]
        public Guid RoleId { get; set; }

        [Display(Name = "Role")]
        public string RoleName { get; set; }

        [Required]
        public Guid ModuleId { get; set; }

        [Display(Name = "Module")]
        public string ModuleName { get; set; }

        [Display(Name = "Can Add")]
        public bool CanAdd { get; set; }

        [Display(Name = "Can Edit")]
        public bool CanEdit { get; set; }

        [Display(Name = "Can Delete")]
        public bool CanDelete { get; set; }

        [Display(Name = "Can View")]
        public bool CanView { get; set; }

        [Display(Name = "Can Print")]
        public bool CanPrint { get; set; }

        public byte[] RowVersion { get; set; }
    }
}