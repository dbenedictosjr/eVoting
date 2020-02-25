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
            this.ElectionID = Guid.NewGuid();
            this.Positions = new List<PositionModel>();
            this.JPositions = new List<JPositionModel>();
        }

        [Required]
        public Guid ElectionID { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Limit Ref. No. to 10 characters.")]
        [Display(Name = "Ref. No.")]
        public string RefCode { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Limit Description to 30 characters.")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Reg. Start Date")]
        [DataType(DataType.Date)]
        public DateTime RegStartDate { get; set; }

        [Required]
        [Display(Name = "Reg. End Date")]
        [DataType(DataType.Date)]
        public DateTime RegEndDate { get; set; }

        [Required]
        [Display(Name = "Voting Start Date")]
        [DataType(DataType.Date)]
        public DateTime VotingStartDate { get; set; }

        [Required]
        [Display(Name = "Voting End Date")]
        [DataType(DataType.Date)]
        public DateTime VotingEndDate { get; set; }

        public byte[] RowVersion { get; set; }

        [IgnoreMap]
        public List<PositionModel> Positions { get; set; }
        public List<JPositionModel> JPositions { get; set; }
    }
}
