using Online_Store.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class ProductEntity : IAuditableRepository
    {
        [Key]
        public Guid ProdID { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string ProdCode { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string ShortDesc { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string LongDesc { get; set; }

        public Guid Cat3ID { get; set; }

        public long UOMID { get; set; }

        public double UnitQty { get; set; }

        public double Mintock { get; set; }

        public double MaxStock { get; set; }

        public double Cost { get; set; }

        public double MarkupAmount { get; set; }

        public double MarkupPercent { get; set; }

        public double Price { get; set; }

        public bool? Vatable { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Barcode { get; set; }

        public double Stock { get; set; }

        public bool? Active { get; set; }

        public Guid CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] RowVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual Category3Entity Category3 { get; set; }
        public virtual UOMEntity OUM { get; set; }
    }
}
