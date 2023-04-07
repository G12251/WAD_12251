using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;
using WebAPI.DAL;

namespace WebAPI.Repositories
{
    public class BookRepository : IProductRepository
    {

        private readonly ProductContext _dbContext;
        public BookRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Books.Find(productId);
            _dbContext.Books.Remove(product);
            Save();
        }
        public Book GetProductById(int productId)
        {
            var prod = _dbContext.Books.Find(productId);
            return prod;
        }
        public IEnumerable<Book> GetProducts()
        {

            return _dbContext.Books.ToList();
            //.Include(s => s.BookCategory).ToList();
        }
        public void InsertProduct(Book product)
        {

            product.BookCategory = _dbContext.Categories.Find(product.BookCategoryId);
            _dbContext.Add(product);
            Save();
        }
        public void UpdateProduct(Book product)
        {
            _dbContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
        

    }
}
