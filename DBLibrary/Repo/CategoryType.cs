using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DBLibrary.Repo
{
    public class CategoryType: ICategory
    {
        private readonly ShopeaseContext _context;
        public CategoryType(ShopeaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> GetCategory()
        {
            return _context.Categories.Include(c => c.Products).ToList();
        }
        public Category GetCategoryById(int id)
        {
            return _context.Categories
                .Include(c => c.Products)
                .ToList()
                .Find(c => c.CategoryId==id);
        }
    }
}
