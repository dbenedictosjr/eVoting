using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class ReferencesModel
    {
        public Guid RefID { get; set; }

        [StringLength(20, ErrorMessage = "Limit Reference Type to 20 characters")]
        public string RefType { get; set; }

        [StringLength(10, ErrorMessage = "Limit Reference Code to 10 characters")]
        public string RefCode { get; set; }

        [StringLength(50, ErrorMessage = "Limit Reference Description to 50 characters")]
        public string RefDescription { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
