using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DynamicMVC.Annotations;

namespace OrderEntryDemo.Models
{
    [DynamicEntity]
    [DynamicMenuItem("Customers", "Order Entry")]
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Customer Region")]
        public int CustomerRegionId { get; set; }

        public CustomerRegion CustomerRegion { get; set; }
    }
}