using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class OrderItemType: IOrderItem
    {
        private readonly ShopeaseContext _context;
        public OrderItemType(ShopeaseContext context)
        {
            _context = context;
        }
        public IEnumerable<OrderItem> GetOrderItem()
        {
            return _context.OrderItems
                .Include(o => o.Order)
                .Include(o => o.Product)
                .ToList();
        }
    }
}
