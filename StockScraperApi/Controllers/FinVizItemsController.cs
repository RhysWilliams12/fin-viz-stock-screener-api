//StockScreenerApi - An API that searches for a stock data from the web
//Copyright(C) 2020  Rhys Williams

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.If not, see<https://www.gnu.org/licenses/>.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockScreenerApi.Logic;
using StockScreenerApi.Models;

namespace StockScreenerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinVizItemsController : ControllerBase
    {
        private readonly FinVizContext _context;

        public FinVizItemsController(FinVizContext context)
        {
            _context = context;
        }

        // GET: api/FinVizItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinVizItem>>> GetFinVizItems()
        {
            return await _context.FinVizItems.ToListAsync();
        }

        // GET: api/FinVizItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FinVizItem>> GetFinVizItem(string id)
        {
            await QueryFinViz(id);

            var finVizItem = await _context.FinVizItems.FindAsync(id);

            return finVizItem;
        }

        // PUT: api/FinVizItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFinVizItem(string id, FinVizItem finVizItem)
        {
            if (id != finVizItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(finVizItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FinVizItemExists(id))
                {
                    return NotFound();
                }
            }

            return NoContent();
        }

        // POST: api/FinVizItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FinVizItem>> PostFinVizItem(FinVizItem finVizItem)
        {
            _context.FinVizItems.Add(finVizItem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FinVizItemExists(finVizItem.Id))
                {
                    return Conflict();
                }
            }

            return CreatedAtAction("GetFinVizItem", new { id = finVizItem.Id }, finVizItem);
        }

        // DELETE: api/FinVizItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FinVizItem>> DeleteFinVizItem(string id)
        {
            var finVizItem = await _context.FinVizItems.FindAsync(id);
            if (finVizItem == null)
            {
                return NotFound();
            }

            _context.FinVizItems.Remove(finVizItem);
            await _context.SaveChangesAsync();

            return finVizItem;
        }

        private bool FinVizItemExists(string id)
        {
            return _context.FinVizItems.Any(e => e.Id == id);
        }

        private async Task QueryFinViz(string symbol)
        {
            var stockScreener = new StockScreener(symbol);
            var finVizData = stockScreener.ScrapeWeb();

            if (FinVizItemExists(symbol))
            {
                await PutFinVizItem(symbol, finVizData);
            }
            else
            {
                await PostFinVizItem(finVizData);
            }
        }
    }
}
