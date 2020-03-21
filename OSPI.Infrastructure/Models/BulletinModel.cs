using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class BulletinModel
    {
        //
        public Guid BulletinId { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Posted")]
        public DateTime DatePosted { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Field exceeds maximum length of 100 characters.")]
        [Display(Name = "Job Title")]
        public string Title { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Field exceeds maximum length of 50 characters.")]
        [Display(Name = "Job Description")]
        public string Description { get; set; }

        public string ImageName { get; set; }

        public Guid MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Fullname")]
        public string FullName { get { return this.FirstName + ' ' + this.LastName; } }

        //
        public byte[] RowVersion { get; set; }
    }
}