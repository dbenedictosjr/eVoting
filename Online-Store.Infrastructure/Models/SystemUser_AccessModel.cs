using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class SystemUser_AccessModel
    {
        public Guid UAID { get; set; }

        public Guid? LevelID { get; set; }

        public Guid? ModuleID { get; set; }

        public bool? CanAdd { get; set; }

        public bool? CanEdit { get; set; }

        public bool? CanDelete { get; set; }

        public bool? CanView { get; set; }

        public bool? CanPrint { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
