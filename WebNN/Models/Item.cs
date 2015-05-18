using System;
using System.Collections.Generic;

namespace WebNN.Models
{
    public partial class Item
    {
        //public Item()
        //{
        //    this.ItemOrders = new List<ItemOrder>();
        //}

        public int ItemId { get; set; }
        public string Name { get; set; }
        //public virtual ICollection<ItemOrder> ItemOrders { get; set; }
    }
}
