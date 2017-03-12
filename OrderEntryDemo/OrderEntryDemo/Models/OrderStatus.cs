using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DynamicMVC.Annotations;

namespace OrderEntryDemo.Models
{
    [DynamicEntity]
    [DynamicMenuItem("Order Status", "Admin")]
    public class OrderStatus
    {
        public OrderStatus()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}