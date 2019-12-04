using System;

namespace Online_Store.Infrastructure.Models
{
    public class ShiftModel
    {
        public Guid ShiftID { get; set; }

        public DateTime? Shift_Start { get; set; }

        public DateTime? Shift_End { get; set; }

        public DateTime? TranDate { get; set; }

        public double? Change_Fund { get; set; }

        public double? Cash_Count { get; set; }

        public double? Cash_Sales { get; set; }

        public double? Cash_Variance { get; set; }

        public int? OpenDrawer { get; set; }

        public Guid? UserID { get; set; }

        public int? Shift { get; set; }

        public int? WorkStation { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
