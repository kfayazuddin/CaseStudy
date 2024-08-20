using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class AddressType: IAddress
    {
        private readonly ShopeaseContext _context;
        public AddressType(ShopeaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Address> GetAddress()
        {
            return _context.Addresses
            .Include(a => a.Shipments)
            .Include(a => a.User)
            .ToList(); 
        }

    }
}
