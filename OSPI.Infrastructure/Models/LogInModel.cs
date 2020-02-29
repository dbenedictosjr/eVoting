using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class LogInModel
    {
        [Required]
        [StringLength(8, ErrorMessage = "Limit User Id to 8 characters.")]
        [Display(Name = "User Id")]
        public string MemberNo { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Limit Password to 20 characters.")]
        public string Password { get; set; }
    }
}