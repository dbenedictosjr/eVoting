﻿using OSPI.Inventory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Inventory.Domain.Entities
{
    public class Product_UnitEntity : IAuditableRepository
    {
        [Key]
        public Guid ProductUnitID { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string ProductUnitDescription { get; set; }

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
