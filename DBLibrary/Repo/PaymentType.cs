using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class PaymentType: IPayment
    {
        private readonly ShopeaseContext _context;
        public PaymentType(ShopeaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Payment> GetPayment()
        {
            return _context.Payments
                .Include(p => p.Order)
                .ToList();
        }
    }
}
