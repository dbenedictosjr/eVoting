﻿using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class ShiftEntity : IAuditableEntity
    {
        [Key]
        public Guid ShiftId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Shift_Start { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Shift_End { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? TranDate { get; set; }

        public double? Change_Fund { get; set; }

        public double? Cash_Count { get; set; }

        public double? Cash_Sales { get; set; }

        public double? Cash_Variance { get; set; }

        public int? OpenDrawer { get; set; }

        public Guid? UserId { get; set; }

        public int? Shift { get; set; }

        public int? WorkStation { get; set; }

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
