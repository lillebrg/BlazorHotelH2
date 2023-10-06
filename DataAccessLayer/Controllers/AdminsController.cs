using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Data;
using DomainModels;
using DataAccessLayer.BusinessLogic;

namespace DataAccessLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        //seperation of concern
        private readonly RepoAdmin repoAdmin;

        public AdminsController()
        {
            repoAdmin = new RepoAdmin();
        }

        // GET: api/Admins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Admin>>> GetAdmins()
        {
            IEnumerable<Admin> adminList = await repoAdmin.GetAdminAsync();
            if (adminList != null)
            {
                return Ok(adminList);
            }
            return NotFound();
        }

        //// GET: api/Admins/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Admin>> GetAdmin(int id)
        //{
        //  if (_context.Admins == null)
        //  {
        //      return NotFound();
        //  }
        //    var admin = await _context.Admins.FindAsync(id);

        //    if (admin == null)
        //    {
        //        return NotFound();
        //    }

        //    return admin;
        //}

        //// PUT: api/Admins/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAdmin(int id, Admin admin)
        //{
        //    if (id != admin.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(admin).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AdminExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Admins
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Admin>> PostAdmin(Admin admin)
        //{
        //  if (_context.Admins == null)
        //  {
        //      return Problem("Entity set 'HotelContext.Admins'  is null.");
        //  }
        //    _context.Admins.Add(admin);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAdmin", new { id = admin.Id }, admin);
        //}

        //// DELETE: api/Admins/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAdmin(int id)
        //{
        //    if (_context.Admins == null)
        //    {
        //        return NotFound();
        //    }
        //    var admin = await _context.Admins.FindAsync(id);
        //    if (admin == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Admins.Remove(admin);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        // GET: api/Customers/5
        [HttpGet("{email}/{password}")]
        public async Task<ActionResult<Admin>> GetAdminEmail(string email, string password)
        {
           var admin = await repoAdmin.GetAdminAsync();
            if (admin == null)
            {
                return NotFound();
            }

            admin = admin.Where(item => item.Email == email && item.Password == password);
            if (admin.Count() != 1 && admin != null)
            {
                return NotFound();
            }

            return admin.First();
        }

        //private bool AdminExists(int id)
        //{
        //    return (_context.Admins?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
