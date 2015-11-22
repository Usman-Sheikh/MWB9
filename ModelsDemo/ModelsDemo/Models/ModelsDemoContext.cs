using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ModelsDemo.Models
{
    public class ModelsDemoContext : DbContext
    {
      
        public ModelsDemoContext() : base("name=ModelsDemoContext")
        {
        }

        public DbSet<Product> Products { get; set; }

        public System.Data.Entity.DbSet<ModelsDemo.Models.ContactMessage> ContactMessages { get; set; }
    }
}
