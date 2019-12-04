using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class SystemUser_LevelModel
    {
        public Guid LevelID { get; set; }

        [StringLength(50, ErrorMessage = "Limit Level Name to 50 characters.")]
        public string LevelName { get; set; }

        [StringLength(500, ErrorMessage = "Limit Level Description to 500 characters.")]
        public string LevelDescription { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
