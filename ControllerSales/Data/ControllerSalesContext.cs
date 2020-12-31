using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControllerSales.Models;

namespace ControllerSales.Data
{
    public class ControllerSalesContext : DbContext
    {
        public ControllerSalesContext (DbContextOptions<ControllerSalesContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }

        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
