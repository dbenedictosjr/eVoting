using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class LogInModel
    {
        [Required]
        [StringLength(8, ErrorMessage = "Limit User ID to 8 characters.")]
        [Display(Name = "User ID")]
        public string MemberNo { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Limit Password to 20 characters.")]
        public string Password { get; set; }
    }
}