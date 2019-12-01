using Online_Store.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class Category1Entity : IAuditableRepository
    {
        [Key]
        public Guid Cat1ID { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Cat1Code { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Cat1Desc { get; set; }

        [Column(TypeName = "varchar(max)")] 
        public string Cat1Img { get; set; }

        public Guid CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] RowVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
