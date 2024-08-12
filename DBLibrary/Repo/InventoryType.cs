using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{

    public class InventoryType: IInventory
    {
        private readonly ShopeaseContext _context;
        public InventoryType(ShopeaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Inventory> GetInventory()
        {
            return _context.Inventories.Include( i => i.Product).ToList();
        }
    }
}
