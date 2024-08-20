using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class WishlistItemType: IWishlistItem
    {
        private readonly ShopeaseContext _context;
        public WishlistItemType(ShopeaseContext context)
        {
            _context = context;
        }

        public IEnumerable<WishlistItem> GetWishlistItem()
        {
            return _context.WishlistItems
                .Include(w => w.Product)
                .Include(w => w.Wishlist)
                .ToList();
        }
    }
}
