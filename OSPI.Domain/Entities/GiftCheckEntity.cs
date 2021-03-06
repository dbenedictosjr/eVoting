﻿using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class GiftCheckEntity : IAuditableEntity
    {
        [Key]
        public Guid GCId { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string GC_No { get; set; }

        public double? GC_Amount { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? GC_From { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? GC_To { get; set; }

        public Guid? StoreId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? TranDate { get; set; }

        public Guid? PayeeReferenceId { get; set; }

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
