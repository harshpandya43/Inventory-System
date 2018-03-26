using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using InventorySystem.Models.Inventory;

namespace InventorySystem.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext() : base("DefaultConnection")
        {
        }

        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Resource> Resources { get; set; }
    }
}