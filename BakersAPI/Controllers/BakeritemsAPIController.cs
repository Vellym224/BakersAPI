using BakersAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BakersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BakeritemsAPIController : ControllerBase
    {
        private readonly BakerContext _context;

        public BakeritemsAPIController(BakerContext context)
        {
            _context = context;
        }

        // GET: api/BakeritemsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bakeritem>>> GetBakerItems()
        {
            if (_context.BakerItems == null)
            {
                return NotFound();
            }
            return await _context.BakerItems.ToListAsync();
        }

        // GET: api/BakeritemsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bakeritem>> GetBakeritem(long id)
        {
            if (_context.BakerItems == null)
            {
                return NotFound();
            }
            var bakeritem = await _context.BakerItems.FindAsync(id);

            if (bakeritem == null)
            {
                return NotFound();
            }

            return bakeritem;
        }

        // PUT: api/BakeritemsAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBakeritem(long id, Bakeritem bakeritem)
        {
            if (id != bakeritem.Id)
            {
                return BadRequest();
            }

            _context.Entry(bakeritem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BakeritemExists(id))
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

        // POST: api/BakeritemsAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bakeritem>> PostBakeritem(Bakeritem bakeritem)
        {
            if (_context.BakerItems == null)
            {
                return Problem("Entity set 'BakerContext.BakerItems'  is null.");
            }

            _context.BakerItems.Add(bakeritem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBakeritem", new { id = bakeritem.Id }, bakeritem);
        }

        // DELETE: api/BakeritemsAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBakeritem(long id)
        {
            if (_context.BakerItems == null)
            {
                return NotFound();
            }
            var bakeritem = await _context.BakerItems.FindAsync(id);
            if (bakeritem == null)
            {
                return NotFound();
            }

            _context.BakerItems.Remove(bakeritem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BakeritemExists(long id)
        {
            return (_context.BakerItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
