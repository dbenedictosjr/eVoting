using OSPI.Inventory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Inventory.Domain.Entities
{
    public class ReferencesEntity : IAuditableRepository
    {
        [Key]
        public Guid RefID { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string RefType { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string RefCode { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string RefDescription { get; set; }

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
