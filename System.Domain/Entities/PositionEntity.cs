﻿using System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace System.Domain.Entities
{
    public class PositionEntity : IAuditableEntity
    {
        [Key]
        public Guid PositionID { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        public string PositionName { get; set; }

        [Column(TypeName = "INT")]
        public int RequiredCandidates { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Qualifications { get; set; }

        public Guid ElectionID { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("ElectionID")]
        public virtual ElectionEntity Election { get; set; }
    }
}
