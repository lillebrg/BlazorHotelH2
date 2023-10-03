using DataAccessLayer.Data;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.BusinessLogic
{
    public class RepoAdmin
    {
        private readonly HotelContext _context;

        public RepoAdmin()
        {
            _context = new HotelContext();
        }

        public async Task<IEnumerable<Admin>> GetAdminAsync()
        {
            return await _context.Admins.ToListAsync();
        }
    }
}
