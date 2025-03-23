using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asrfly.Core.SqlServer {
    public class DBContext : DbContext {
        public DBContext() {
        }

        // Set ConString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var sqlCon = @"Server=localhost\SQLEXPRESS;Database=AsrflyDataBase;Trusted_Connection=True;TrustServerCertificate=True;"; // For DEveleopment And Test
            optionsBuilder.UseSqlServer(sqlCon);

        }

        // Tables
        public DbSet<Categories> Categories { get; set; }
        public DbSet<SystemRecords> SystemRecords { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
    }
}
