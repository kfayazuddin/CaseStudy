using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class ShipmentType: IShipment
    {
        private readonly ShopeaseContext _context;
        public ShipmentType(ShopeaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Shipment> GetShipment()
        {
            return _context.Shipments
                .Include(s => s.Address)
                .Include(s => s.Order)
                .ToList();
        }
    }
}
