﻿using System.ComponentModel.DataAnnotations;

namespace AbbyWeb.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
