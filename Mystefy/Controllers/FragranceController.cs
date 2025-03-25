using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mystefy.Data;
using Mystefy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mystefy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FragranceController : ControllerBase
    {
        private readonly MystefyDbContext _context;

        public FragranceController(MystefyDbContext context)
        {
            _context = context;
        }

        // GET: api/Fragrance
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fragrance>>> GetFragrances()
        {
            return await _context.Fragrances.ToListAsync();
        }

        // GET: api/Fragrance/{id}
        [HttpGet("{FragranceID}")]
        public async Task<ActionResult<Fragrance>> GetFragrance(int FragranceID)
        {
            var fragrance = await _context.Fragrances.FindAsync(FragranceID);

            if (fragrance == null)
            {
                return NotFound();
            }

            return fragrance;
        }

        // POST: api/Fragrance
        [HttpPost]
        public async Task<ActionResult<Fragrance>> PostFragrance(Fragrance fragrance)
        {
            _context.Fragrances.Add(fragrance);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFragrance), new { id = fragrance.FragranceID }, fragrance);
        }

        // PUT: api/Fragrance/{id}
        [HttpPut("{FragranceID}")]
        public async Task<IActionResult> PutFragrance(int FragranceID, Fragrance fragrance)
        {
            if (FragranceID != fragrance.FragranceID)
            {
                return BadRequest();
            }

            _context.Entry(fragrance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FragranceExists(FragranceID))
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

        // DELETE: api/Fragrance/{id}
        [HttpDelete("{FragranceID}")]
        public async Task<IActionResult> DeleteFragrance(int FragranceID)
        {
            var fragrance = await _context.Fragrances.FindAsync(FragranceID);
            if (fragrance == null)
            {
                return NotFound();
            }

            _context.Fragrances.Remove(fragrance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FragranceExists(int FragranceID)
        {
            return _context.Fragrances.Any(e => e.FragranceID == FragranceID);
        }
    }
}

