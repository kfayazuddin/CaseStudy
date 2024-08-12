using DBLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public interface IOrder
    {
        public IEnumerable<Order> GetOrder();
        public Order GetOrderById(int id);

    }
}
