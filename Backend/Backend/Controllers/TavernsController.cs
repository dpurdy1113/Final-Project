using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Taverns")]
    public class TavernsController : Controller
    {
        private readonly TavernContext _context;

        public TavernsController(TavernContext context)
        {
            _context = context;
        }

        // GET: api/Taverns
        [HttpGet]
        public IEnumerable<Tavern> GetTavern()
        {
            return _context.Tavern;
        }

        // GET: api/Taverns/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTavern([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tavern = await _context.Tavern.SingleOrDefaultAsync(m => m.ID == id);

            if (tavern == null)
            {
                return NotFound();
            }

            return Ok(tavern);
        }

        // PUT: api/Taverns/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTavern([FromRoute] int id, [FromBody] Tavern tavern)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tavern.ID)
            {
                return BadRequest();
            }

            _context.Entry(tavern).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TavernExists(id))
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

        // POST: api/Taverns
        [HttpPost]
        public async Task<IActionResult> PostTavern([FromBody] Tavern tavern)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Tavern.Add(tavern);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTavern", new { id = tavern.ID }, tavern);
        }

        // DELETE: api/Taverns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTavern([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tavern = await _context.Tavern.SingleOrDefaultAsync(m => m.ID == id);
            if (tavern == null)
            {
                return NotFound();
            }

            _context.Tavern.Remove(tavern);
            await _context.SaveChangesAsync();

            return Ok(tavern);
        }

        private bool TavernExists(int id)
        {
            return _context.Tavern.Any(e => e.ID == id);
        }
    }
}