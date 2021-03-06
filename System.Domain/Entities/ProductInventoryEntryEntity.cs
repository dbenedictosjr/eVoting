﻿using System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace System.Domain.Entities
{
    public class ProductInventoryEntryEntity : IAuditableEntity
    {
        [Key]
        public Guid ProductInventoryEntryID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? TranDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? InvDate { get; set; }

        public Guid? StatusID { get; set; }

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
