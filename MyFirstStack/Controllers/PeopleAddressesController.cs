using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstStack.Data;
using MyFirstStack.Models;

namespace MyFirstStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleAddressesController : ControllerBase
    {
        private readonly MyFirstStackDb _context;

        public PeopleAddressesController(MyFirstStackDb context)
        {
            _context = context;
        }

        // GET: api/PeopleAddresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeopleAddresses>>> GetPeopleAddress()
        {
            return await _context.PeopleAddress.ToListAsync();
        }

        // GET: api/PeopleAddresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PeopleAddresses>> GetPeopleAddresses(int id)
        {
            var peopleAddresses = await _context.PeopleAddress.FindAsync(id);

            if (peopleAddresses == null)
            {
                return NotFound();
            }

            return peopleAddresses;
        }

        // PUT: api/PeopleAddresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeopleAddresses(int id, PeopleAddresses peopleAddresses)
        {
            if (id != peopleAddresses.PeopleAddressesId)
            {
                return BadRequest();
            }

            _context.Entry(peopleAddresses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeopleAddressesExists(id))
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

        // POST: api/PeopleAddresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PeopleAddresses>> PostPeopleAddresses(PeopleAddresses peopleAddresses)
        {
            _context.PeopleAddress.Add(peopleAddresses);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPeopleAddresses", new { id = peopleAddresses.PeopleAddressesId }, peopleAddresses);
        }

        // DELETE: api/PeopleAddresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePeopleAddresses(int id)
        {
            var peopleAddresses = await _context.PeopleAddress.FindAsync(id);
            if (peopleAddresses == null)
            {
                return NotFound();
            }

            _context.PeopleAddress.Remove(peopleAddresses);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PeopleAddressesExists(int id)
        {
            return _context.PeopleAddress.Any(e => e.PeopleAddressesId == id);
        }
    }
}
