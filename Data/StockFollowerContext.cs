using StockFollower.Models;
using Microsoft.EntityFrameworkCore;

namespace StockFollower.Data
{

    public class StockFollowerContext : DbContext
    {
        public StockFollowerContext(DbContextOptions<StockFollowerContext> options) : base(options)
        {

        }
        public DbSet<Stock> Stocks {get; set;}

    }
}