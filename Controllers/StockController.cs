using System.Collections.Generic;
using StockFollower.Data;
using StockFollower.Models;
using Microsoft.AspNetCore.Mvc;

namespace StockFollower.Controllers
{
    [Route("api/stocks")] 
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockRepo _repository;
        public StockController(IStockRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult <IEnumerable<Stock>> GetAllCommands()
        {
            var commandItems = _repository.GetAllStocks();

            return Ok(commandItems);
        }   
        //Get api/commands/5 
        [HttpGet("{id}")]
        public ActionResult <Stock> GetStockById(int id)
        {
            var commandItem = _repository.GetStockById(id);
            return Ok(commandItem);
        }   
        [HttpPost]
        public ActionResult <Stock> SaveStock([FromBody]Stock stock)
        {
            var commandItem = _repository.SaveStock(stock);
            return Ok(commandItem);
        }

        [HttpPut]
        public ActionResult <Stock> UpdateStock([FromBody]Stock stock)
        {
            var commandItem = _repository.UpdateStock(stock);
            return Ok(commandItem);
        }   
        [HttpDelete("{id}")]
        public void DeleteStock(int id)
        {
            _repository.DeleteStock(id);
        }
    }

}