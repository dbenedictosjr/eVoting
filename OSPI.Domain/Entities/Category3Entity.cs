using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class Category3Entity : IAuditableEntity
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

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        public virtual ICollection<ProductEntity> ProductEntity { get; set; }
        public virtual Category2Entity Category2 { get; set; }
    }
}
