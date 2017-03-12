using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DynamicMVC.Annotations;

namespace OrderEntryDemo.Models
{
    [DynamicEntity]
    [DynamicMenuItem("Product", "Order Entry")]
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}