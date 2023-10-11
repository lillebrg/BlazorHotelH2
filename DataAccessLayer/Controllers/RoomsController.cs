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
    public class RoomsController : ControllerBase
    {
        //seperation of concern
        private readonly RepoRoom repoRoom;

        public RoomsController()
        {
            repoRoom = new RepoRoom();
        }

        // GET: api/Rooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetRoom()
        {
            IEnumerable<Room> roomList = await repoRoom.GetRoomAsync();
            if (roomList != null)
            {
                return Ok(roomList);
            }
            return NotFound();
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoom(int id)
        {
            Room room = (Room)await repoRoom.GetRoomAsync(id);
            if (room != null)
            {
                return Ok(room);
            }
            return NotFound();
        }

        // PUT: api/Rooms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom(int id, Room room)
        {
            room = await repoRoom.PutRoomAsync(id, room);

            return NoContent();
        }

        // POST: api/Rooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Room>> PostRoom(Room room)
        {
            await repoRoom.PostRoomAsync(room);
            return CreatedAtAction("GetCustomer", new { id = room.Id }, room);
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            if (await repoRoom.DeleteRoomAsync(id) == null)
            {
                return NotFound();
            }
            return NoContent();
        }

        
    }
}
