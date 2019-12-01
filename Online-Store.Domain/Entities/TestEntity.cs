using Online_Store.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Online_Store.Domain.Entities
{
    public class TestEntity : IAuditableRepository
    {
        [Key]
        public Guid ID { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Code { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Desc { get; set; }

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
