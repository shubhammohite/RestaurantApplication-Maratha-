using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Maratha_Restaurant_Application.Models;

namespace Maratha_Restaurant_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly MarathaRestaurantDBContext _context;

        public OrderController(MarathaRestaurantDBContext context)
        {
            _context = context;
        }

        // GET: api/Order
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderMasters>>> GetOrderMasters()
        {
            return await _context.OrderMasters.ToListAsync();
        }

        // GET: api/Order/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderMasters>> GetOrderMasters(long id)
        {
            var orderMasters = await _context.OrderMasters.FindAsync(id);

            if (orderMasters == null)
            {
                return NotFound();
            }

            return orderMasters;
        }

        // PUT: api/Order/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderMasters(long id, OrderMasters orderMasters)
        {
            if (id != orderMasters.OrderMasterId)
            {
                return BadRequest();
            }

            _context.Entry(orderMasters).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderMastersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Order
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderMasters>> PostOrderMasters(OrderMasters orderMasters)
        {
            _context.OrderMasters.Add(orderMasters);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderMasters", new { id = orderMasters.OrderMasterId }, orderMasters);
        }

        // DELETE: api/Order/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderMasters(long id)
        {
            var orderMasters = await _context.OrderMasters.FindAsync(id);
            if (orderMasters == null)
            {
                return NotFound();
            }

            _context.OrderMasters.Remove(orderMasters);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderMastersExists(long id)
        {
            return _context.OrderMasters.Any(e => e.OrderMasterId == id);
        }
    }
}
