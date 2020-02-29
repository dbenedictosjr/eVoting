﻿using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class RTPEntity : IAuditableEntity
    {
        [Key]
        public Guid RTPId { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string RTPNo { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? TranDate { get; set; }

        public Guid? SupplierId { get; set; }

        [Column(TypeName = "varchar(500")]
        public string Remarks { get; set; }

        public Guid? StatusId { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}
