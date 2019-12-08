﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class Category1Model
    {
        [Required]
        public Guid ID { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Limit Code to 10 characters.")]
        public string Code { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Limit Description to 50 characters.")]
        public string Description { get; set; }

        public string Image { get; set; }

        public byte[] RowVersion { get; set; }

    }
}
