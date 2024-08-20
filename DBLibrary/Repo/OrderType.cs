using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class OrderType: IOrder
    {
        private readonly ShopeaseContext _context;
        public OrderType(ShopeaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Order> GetOrder()
        {
            return _context.Orders
                .Include(o => o.User)
                .Include(o => o.Payments)
                .Include(o => o.Shipments)
                .Include(o => o.OrderItems)
                .ToList();
        }
        public Order GetOrderById(int id)
        {
            return _context.Orders.Find(id);
        }
    }
}
