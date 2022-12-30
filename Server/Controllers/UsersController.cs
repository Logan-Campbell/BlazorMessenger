using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LANMessanger.Server.Models;
using LANMessenger.Server.Data;
using LANMessenger.Server.AutoMapper;
using LANMessenger.Shared.Models;
using AutoMapper;

namespace LANMessenger.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly LANMessengerServerContext _context;
        private readonly IMapper _mapper;

        public UsersController(LANMessengerServerContext context)
        {
            _context = context;
            var config = new MapperConfiguration(cfg => cfg.AddProfile<UserMappingProfile>());
            _mapper = new Mapper(config);
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
          if (_context.User == null)
          {
              return NotFound();
          }
            IEnumerable<User> users = await _context.User.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<UserDTO>>(await _context.User.ToListAsync()));
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetUser(int id)
        {
          if (_context.User == null)
          {
              return NotFound();
          }
            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return _mapper.Map<UserDTO>(user);
        }

        // GET: api/Users/Login?username=5&password=5
        [HttpGet("Login")]
        public async Task<ActionResult<UserDTO>> GetUserByUsernameAndPassword([FromQuery] string username, [FromQuery] string password)
        {
            if (_context.User == null)
            {
                return NotFound();
            }
            var user = await _context
                .User
                .Where(u => username == u.username)
                .Where(u => password == u.password)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                return NotFound();
            }
            UserDTO userDTO = _mapper.Map<UserDTO>(user);
            //Don't need to send the password back
            userDTO.password = null;
            return userDTO;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
          if (_context.User == null)
          {
              return Problem("Entity set 'LANMessengerServerContext.User'  is null.");
          }
            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (_context.User == null)
            {
                return NotFound();
            }
            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.User.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return (_context.User?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
