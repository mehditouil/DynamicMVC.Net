using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DynamicMVC.Annotations;

namespace OrderEntryDemo.Models
{
    [DynamicEntity]
    [DynamicMenuItemExclude]
    public class OrderLine
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
    }
}