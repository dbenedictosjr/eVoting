using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class MemberModel
    {
        [Required]
        public Guid MemberId { get; set; }

        [Required]
        [Display(Name = "CId No")]
        [StringLength(8, ErrorMessage = "Limit CId No to 8 characters.")]
        public string MemberNo { get; set; }

        [Required]
        [Display(Name = "Reg. Date")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        [Required]
        [Display(Name = "Firs tName")]
        [StringLength(30, ErrorMessage = "Limit First Name to 30 characters.")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(30, ErrorMessage = "Limit Middle Name to 30 characters.")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Limit Last Name to 30 characters.")]
        public string LastName { get; set; }

        public string MemberFullName { get { return this.FirstName + ' ' + this.LastName; } }

        [Required]
        [Display(Name = "Home Address")]
        [StringLength(150, ErrorMessage = "Limit Home Address to 150 characters.")]
        public string HomeAddress { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [StringLength(50, ErrorMessage = "Limit Email Address to 50 characters.")]
        public string EmailAddress { get; set; }

        [Display(Name = "Phone No")]
        [StringLength(15, ErrorMessage = "Limit Phone No to 15 characters.")]
        public string PhoneNo { get; set; }

        [Display(Name = "Mobile No")]
        [StringLength(15, ErrorMessage = "Limit Mobile No to 15 characters.")]
        public string MobileNo { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Capital")]
        public Double Capital { get; set; }

        [Required]
        [Display(Name = "Member Status")]
        public string MemberStatus { get; set; }

        [Required]
        [Display(Name = "Credit Status")]
        public string CreditStatus { get; set; }

        [DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = "Limit Password to 20 characters.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Date Hired")]
        [DataType(DataType.Date)]
        public DateTime DateHired { get; set; }

        [Display(Name = "Salary")]
        public double Salary { get; set; }

        [StringLength(30, ErrorMessage = "Limit Account No to 30 characters.")]
        [Display(Name = "Account No")]
        public string AccountNo { get; set; }

        [Required]
        public Guid RoleId { get; set; }

        [Display(Name = "Role")]
        public string RoleName { get; set; }

        public byte[] RowVersion { get; set; }
    }
}