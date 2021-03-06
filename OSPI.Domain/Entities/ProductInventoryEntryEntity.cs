﻿using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class ProductInventoryEntryEntity : IAuditableEntity
    {
        [Key]
        public Guid ProductInventoryEntryId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? TranDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? InvDate { get; set; }

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
