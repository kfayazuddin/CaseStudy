using DBLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public interface IProduct
    {
        public IEnumerable<Product> GetProduct();
        public Product GetProductById(int id);
    }
}
