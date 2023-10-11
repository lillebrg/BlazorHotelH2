using DataAccessLayer.Controllers;
using DataAccessLayer.Data;
using DomainModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.BusinessLogic
{
    public class RepoRoom
    {
        private readonly HotelContext _context;

        public RepoRoom()
        {
            _context = new HotelContext();
        }

        public async Task<IEnumerable<Room>> GetRoomAsync()
        {
            var roomsWithPictures = await _context.Room
                .Include(r => r.Pictures)
                .ToListAsync();

            return roomsWithPictures;
        }

        public async Task<Room> GetRoomAsync(int id)
        {
            var room = await _context.Room.FindAsync(id);

            return room;
        }

        public async Task<Room> PutRoomAsync(int id, Room room)
        {
            if (id != room.Id)
            {
                return null;
            }

            _context.Entry(room).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomExists(id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return room;
        }

        public async Task<Room> PostRoomAsync(Room room)
        {
            _context.Room.Add(room);
            await _context.SaveChangesAsync();

            return room;
        }

        public async Task<Room> DeleteRoomAsync(int id)
        {
            var room = await _context.Room.FindAsync(id);
            if (room == null)
            {
                return null;
            }

            _context.Room.Remove(room);
            await _context.SaveChangesAsync();

            return room;
        }

        private bool RoomExists(int id)
        {
            return (_context.Room?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
