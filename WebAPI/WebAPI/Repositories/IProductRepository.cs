using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IProductRepository
    {
        void InsertProduct(Book product);

        void UpdateProduct(Book product);

        void DeleteProduct(int productid);

        Book GetProductById(int Id);

        IEnumerable<Book> GetProducts();
    }
}
