using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal  Price { get; set; }
        public int BookCategoryId { get; set; }
        public Category BookCategory { get; set; }
    }
}
