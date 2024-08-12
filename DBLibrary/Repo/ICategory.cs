using DBLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public interface ICategory
    {
        public IEnumerable<Category> GetCategory();
        public Category GetCategoryById(int id);
    }
}
