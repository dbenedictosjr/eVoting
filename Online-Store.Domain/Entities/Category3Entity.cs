using Online_Store.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class Category3Entity : IAuditableRepository
    {
        [Key]
        public Guid Cat3ID { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Cat3Code { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Cat3Desc { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string Cat3Img { get; set; }

        public Guid Cat2ID { get; set; }

        public Guid CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] RowVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual ICollection<ProductEntity> ProductEntity { get; set; }
        public virtual Category2Entity Category2 { get; set; }
    }
}
