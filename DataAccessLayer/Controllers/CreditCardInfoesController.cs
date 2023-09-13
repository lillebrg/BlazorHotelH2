using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Data;
using DomainModels;

namespace DataAccessLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardInfoesController : ControllerBase
    {
        private readonly HotelContext _context;

        public CreditCardInfoesController(HotelContext context)
        {
            _context = context;
        }

        // GET: api/CreditCardInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CreditCardInfo>>> GetCreditCardInfo()
        {
          if (_context.CreditCardInfo == null)
          {
              return NotFound();
          }
            return await _context.CreditCardInfo.ToListAsync();
        }

        // GET: api/CreditCardInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CreditCardInfo>> GetCreditCardInfo(int id)
        {
          if (_context.CreditCardInfo == null)
          {
              return NotFound();
          }
            var creditCardInfo = await _context.CreditCardInfo.FindAsync(id);

            if (creditCardInfo == null)
            {
                return NotFound();
            }

            return creditCardInfo;
        }

        // PUT: api/CreditCardInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCreditCardInfo(int id, CreditCardInfo creditCardInfo)
        {
            if (id != creditCardInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(creditCardInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreditCardInfoExists(id))
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

        // POST: api/CreditCardInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CreditCardInfo>> PostCreditCardInfo(CreditCardInfo creditCardInfo)
        {
          if (_context.CreditCardInfo == null)
          {
              return Problem("Entity set 'HotelContext.CreditCardInfo'  is null.");
          }
            _context.CreditCardInfo.Add(creditCardInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCreditCardInfo", new { id = creditCardInfo.Id }, creditCardInfo);
        }

        // DELETE: api/CreditCardInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCreditCardInfo(int id)
        {
            if (_context.CreditCardInfo == null)
            {
                return NotFound();
            }
            var creditCardInfo = await _context.CreditCardInfo.FindAsync(id);
            if (creditCardInfo == null)
            {
                return NotFound();
            }

            _context.CreditCardInfo.Remove(creditCardInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CreditCardInfoExists(int id)
        {
            return (_context.CreditCardInfo?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
