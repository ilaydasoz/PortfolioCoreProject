using System;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreProject_Api.DAL.Entity;

namespace PortfolioCoreProject_Api.DAL.ApiContent
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=PortfolioDb2;Username=postgres;Password=postgres");

        public DbSet<Category> Categories { get; set; }

    }
}
