using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class ModuleModel
    {
        [Required]
        public Guid ModuleID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Limit Name to 100 characters.")]
        public string ModuleName { get; set; }

        public byte[] RowVersion { get; set; }
    }
}