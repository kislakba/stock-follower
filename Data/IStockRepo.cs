using System.Collections.Generic;
using StockFollower.Models;
namespace StockFollower.Data
{
    public interface IStockRepo
    {
        IEnumerable<Stock> GetAllStocks();
        Stock GetStockById(int id);
        Stock SaveStock(Stock stock);
        Stock UpdateStock(Stock stock);
        void DeleteStock(int id);
    }
    
}