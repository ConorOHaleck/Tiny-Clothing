using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiny_Clothing.Models;

namespace Tiny_Clothing.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }
            //Add a DbSet for each Entity that needs a table in the database
            public DbSet<Item> Items { get; set; }
    }
 }

