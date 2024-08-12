using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class DiscountType: IDiscount
    {
        private readonly ShopeaseContext _context;
        public DiscountType(ShopeaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Discount> GetDiscount()
        {
            return _context.Discounts
                .Include(d => d.Product)
                .ToList();
        }
    }
}
