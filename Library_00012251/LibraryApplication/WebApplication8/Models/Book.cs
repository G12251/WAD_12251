using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public BookCategory BookCategory { get; set; }

    }
        public enum BookCategory
        { 
            fiction,
            science,
            fantasy
        }
}
