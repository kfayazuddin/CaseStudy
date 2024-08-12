using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class WishlistType: IWishlist
    {
        private readonly ShopeaseContext _context;
        public WishlistType(ShopeaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Wishlist> GetWishlist()
        {
            return _context.Wishlists
                .Include(w => w.User)
                .Include(w => w.WishlistItems)
                .ToList();
        }
    }
}
