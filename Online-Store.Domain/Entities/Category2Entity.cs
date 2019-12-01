using Online_Store.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class Category2Entity : IAuditableRepository
    {
        [Key]
        public Guid Cat2ID { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Cat2Code { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Cat2Desc { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string Cat2Img { get; set; }

        public Guid Cat1ID { get; set; }

        public Guid CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] RowVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual Category1Entity Category1 { get; set; }
    }
}
