using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class ProductType: IProduct
    {
        private readonly ShopeaseContext _context;
        public ProductType(ShopeaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProduct()
        {
            return _context.Products
                .Include(p => p.Category)
                .Include(p => p.Inventory)
                .Include(p => p.Discounts)
                .Include(p => p.CartItems)
                .Include(p => p.WishlistItems)
                .Include(p => p.OrderItems)
                .Include(p => p.Reviews)
                .ToList();
        }
        public Product GetProductById(int id)
        {
            return _context.Products
                .Include(p => p.Category)
                .Include(p => p.Inventory)
                .Include(p => p.Discounts)
                .Include(p => p.CartItems)
                .Include(p => p.WishlistItems)
                .Include(p => p.OrderItems)
                .Include(p => p.Reviews)
                .ToList()
                .Find(p => p.ProductId==id);
        }
    }
}
