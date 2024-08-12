using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class ReviewType: IReview
    {
        private readonly ShopeaseContext _context;
        public ReviewType(ShopeaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Review> GetReview()
        {
            return _context.Reviews
                .Include(r => r.Product)
                .Include(r => r.User)
                .ToList();
        }
    }
}
