using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DinerMax3000
{
    public class Order
    {
        private List<MenuItem> orderItems;
        public Order()
        {
            orderItems = new List<MenuItem>();
        }

        public List<MenuItem> GetOrderItems()
        {
            return this.orderItems;
        }

        public void SetOrderItems(List<MenuItem> orderItems)
        {
            this.orderItems = orderItems;
        }
    }
}
