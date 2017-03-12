using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DynamicMVC.Annotations;

namespace OrderEntryDemo.Models
{
    [DynamicEntity(IndexProperties = "OrderDate, CustomerId, OrderStatusId, Total", ShowEdit = false, CreateProperties = "OrderDate, CustomerId")]
    [DynamicMenuItem("Orders", "Order Entry")]
    [DynamicHeader(CreateHeader = "Select a Customer")]
    public class Order
    {
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
            OrderDate = DateTime.Now;
            OrderStatusId = 1; //new order
        }

        public int Id { get; set; }
        [DisplayName("Order Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [UIHint("DynamicEditorReadOnly")]
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [DisplayName("Order Status")]
        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal Total { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; }
    }
}