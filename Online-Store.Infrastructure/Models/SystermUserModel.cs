using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class SystemUserModel
    {
        public Guid UserID { get; set; }

        [StringLength(20, ErrorMessage = "Limit User Code to 20 characters.")]
        public string UserCode { get; set; }

        [StringLength(100, ErrorMessage = "Limit Username to 100 characters.")]
        public string UserName { get; set; }

        [StringLength(20, ErrorMessage = "Limit User Password to 20 characters.")]
        public string UserPassword { get; set; }

        public DateTime? UserValidity { get; set; }

        public bool? UserLocked { get; set; }

        public bool? UserReset { get; set; }

        public Guid? LevelID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
