using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class CartItemType: ICartItem
    {
        private readonly ShopeaseContext _context;
        public CartItemType(ShopeaseContext context)
        {
            _context = context;
        }
        public IEnumerable<CartItem> GetCartItem()
        {
            return _context.CartItems
                .Include(c => c.Product)
                .ToList();
        }
    }
}
