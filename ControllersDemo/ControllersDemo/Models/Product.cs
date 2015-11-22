using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControllersDemo.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Qty { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}