using OSPI.Inventory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Inventory.Domain.Entities
{
    public class SystemUser_LevelEntity : IAuditableRepository
    {
        [Key]
        public Guid LevelID { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string LevelName { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string LevelDescription { get; set; }

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
