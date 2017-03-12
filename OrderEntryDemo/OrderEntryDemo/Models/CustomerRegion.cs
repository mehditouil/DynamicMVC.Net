using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DynamicMVC.Annotations;

namespace OrderEntryDemo.Models
{
    [DynamicEntity]
    [DynamicMenuItem("Customer Regions", "Admin")]
    public class CustomerRegion
    {
        public CustomerRegion()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}