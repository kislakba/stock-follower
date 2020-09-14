using System.Collections.Generic;
using System.Linq;
using StockFollower.Models;

namespace StockFollower.Data
{
    public class SqlStockRepo : IStockRepo
    {
        private readonly StockFollowerContext _context;

        public SqlStockRepo(StockFollowerContext context)
        {
            _context = context;
        }

        public void DeleteStock(int id)
        {
            var deletedStock = GetStockById(id);
            _context.Stocks.Remove(deletedStock);
            _context.SaveChanges();

        }

        public IEnumerable<Stock> GetAllStocks()
        {
            return _context.Stocks.ToList();
        }

        public Stock GetStockById(int id)
        {
            return _context.Stocks.FirstOrDefault(p => p.id == id);
        }

        public Stock SaveStock(Stock stock)
        {
            _context.Stocks.Add(stock);
            _context.SaveChanges();
            return stock;
        }

        public Stock UpdateStock(Stock stock)
        {
            _context.Stocks.Update(stock);
            _context.SaveChanges();
            return stock;
        }
    }
}