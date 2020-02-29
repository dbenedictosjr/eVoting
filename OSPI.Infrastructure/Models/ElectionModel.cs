using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class ElectionModel
    {
        public ElectionModel()
        {
            this.ElectionId = Guid.NewGuid();
            this.Positions = new List<PositionModel>();
            this.JPositions = new List<JPositionModel>();
        }

        [Required]
        public Guid ElectionId { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Limit Ref. No. to 10 characters.")]
        [Display(Name = "Ref. No.")]
        public string RefCode { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Limit Description to 30 characters.")]
        public string Description { get; set; }



        [Display(Name = "Reg. Start Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RegStartDate { get; set; }


        [Display(Name = "Reg. End Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RegEndDate { get; set; }


        [Display(Name = "Voting Start Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime VotingStartDate { get; set; }


        [Display(Name = "Voting End Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime VotingEndDate { get; set; }

        public byte[] RowVersion { get; set; }

        public ICollection<PositionModel> Positions { get; set; }
        public List<JPositionModel> JPositions { get; set; }
    }
}
