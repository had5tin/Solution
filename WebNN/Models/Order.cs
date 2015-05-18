using System;
using System.Collections.Generic;

namespace WebNN.Models
{
    public partial class Order
    {
        public Order()
        {
            this.ItemOrders = new List<ItemOrder>();
        }

        public int OrderId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ItemOrder> ItemOrders { get; set; }
    }
}
