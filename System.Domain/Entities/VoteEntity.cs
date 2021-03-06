﻿using System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace System.Domain.Entities
{
    public class VoteEntity : IAuditableEntity
    {
        [Key]
        public Guid VoteID { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime DateVoted { get; set; }
        
        public Guid MemberID { get; set; }

        public Guid ElectionID { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("MemberID")]
        public virtual MemberEntity Member { get; set; }

        [ForeignKey("ElectionID")]
        public virtual ElectionEntity Election { get; set; }
    }
}