using Online_Store.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class UOMEntity : IAuditableRepository
    {
        [Key]
        public Guid UOMID { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string UOMCode { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string UOMDesc { get; set; }

        public Guid CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] RowVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual ICollection<ProductEntity> ProductEntity { get; set; }
    }
}
