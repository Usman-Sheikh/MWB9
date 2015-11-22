using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsDemo.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual List<Category> Categories { get; set; }



    }
}