using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ps_12.Data
{
    public class Ps_12CDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Ps_12CDbContext() : base("name=Ps_12CDbContext")
        {
        }

        public System.Data.Entity.DbSet<Ps_12.Models.Comment> Comments { get; set; }

        public System.Data.Entity.DbSet<Ps_12.Models.Post> Posts { get; set; }
    }
}
