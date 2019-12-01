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

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        public virtual ICollection<ProductEntity> ProductEntity { get; set; }
    }
}
