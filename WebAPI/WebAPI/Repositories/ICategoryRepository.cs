using System.Collections.Generic;
using WebAPI.Models;
namespace WebAPI.Repositories
{
    public interface ICategoryRepository
    {
        void InsertCategory(Category category);

        void UpdateCategory(Category category);

        void DeleteCategory(int categoryid);

        Category GetCategoryById(int Id);

        IEnumerable<Category> GetGategory();
    }
}
