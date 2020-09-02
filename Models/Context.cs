using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiDemo.Models
{
    public class Context:DbContext
    {
        public Context() : base("cs") { }

        public DbSet<Menu> Menus { get; set; }
    }
}