using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class CartType: ICart
    {
        private readonly ShopeaseContext _context;
        public CartType(ShopeaseContext context)
        {
            _context = context;
        }


        public IEnumerable<Cart> GetCart()
        {
            return _context.Carts
                .Include(c => c.CartItems)
                .Include(c => c.User)
                .ToList();
        }
    }
}
