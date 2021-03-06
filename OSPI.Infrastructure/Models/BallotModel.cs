﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Infrastructure.Models
{
    public class BallotModel
    {
        public BallotModel()
        {
            this.Positions = new List<PositionModel>();
            this.JPositions = new List<JPositionModel>();
        }

        [Required]
        public Guid BallotId { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Limit Ref. No. to 10 characters.")]
        [Display(Name = "Ref. No.")]
        public string RefCode { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Limit Description to 30 characters.")]
        public string Description { get; set; }

        [Display(Name = "Reg. Start Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime RegStartDate { get; set; }
        public string EditRegStartDate { get; set; }

        [Display(Name = "Reg. End Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime RegEndDate { get; set; }
        public string EditRegEndDate { get; set; }

        [Display(Name = "Voting Start Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime VotingStartDate { get; set; }
        public string EditVotingStartDate { get; set; }

        [Display(Name = "Voting End Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime VotingEndDate { get; set; }
        public string EditVotingEndDate { get; set; }

        public string Status { get; set; }

        public byte[] RowVersion { get; set; }

        public ICollection<PositionModel> Positions { get; set; }
        public List<JPositionModel> JPositions { get; set; }
    }
}
