using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace FancyFolks.Models
{
    public class FancyFolkDbContext : DbContext
    {
        public FancyFolkDbContext() : base("FancyFolksDb")
        {
            Database.SetInitializer<FancyFolkDbContext>(new FancyFolkDbInitializer());
        }

        public DbSet<FancyFolk> FancyFolks { get; set; }
    }
}