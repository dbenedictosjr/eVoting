using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class RoleModel
    {
        [Required]
        public Guid RoleID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Limit Code to 50 characters.")]
        [Display(Name = "Role")]
        public string RoleName { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Limit Description to 250 characters.")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public byte[] RowVersion { get; set; }
    }
}