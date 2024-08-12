using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class CustomerType: ICustomer
    {
        private readonly ShopeaseContext _context;
        public CustomerType(ShopeaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer> GetCustomer()
        {
            return _context.Customers
                .Include(c => c.Wishlists)
                .Include(c => c.Addresses)
                .Include(c => c.Carts)
                .Include(c => c.Orders)
                .Include(c => c.Reviews)
                .ToList(); 
        }
        public Customer GetCustomerById(int id)
        {
            return _context.Customers
                .Include(c => c.Wishlists)
                .Include(c => c.Addresses)
                .Include(c => c.Carts)
                .Include(c => c.Orders)
                .Include(c => c.Reviews)
                .ToList()
                .Find(c => c.UserId==id);
        }

    }
}
