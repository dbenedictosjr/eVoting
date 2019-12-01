﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class Category3Model
    {
        [Required]
        public Guid ID { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Limit Code to 10 characters.")]
        public string Code { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Limit Description to 50 characters.")]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public Guid Cat2ID { get; set; }

        public byte[] RowVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
