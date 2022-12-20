using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LANMessanger.Server.Models;
using LANMessenger.Server.Data;
using LANMessenger.Shared.Models;
namespace LANMessenger.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMessagesController : ControllerBase
    {
        private readonly LANMessengerServerContext _context;

        public UserMessagesController(LANMessengerServerContext context)
        {
            _context = context;
        }


        // GET: api/UserMessages/5
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserMessageDTO>>> GetUserMessages([FromQuery] int recieverId)
        {
            if (_context.Message == null || _context.User == null)
            {
                return NotFound();
            }

            var query = await _context
                .Message
                .Include(u => u.Sender)
                .Where(m => m.RecieverId == recieverId)
                .ToListAsync();

            //Convert Message + User to a userMessages List
            List<UserMessageDTO> userMessages = new List<UserMessageDTO>();
            foreach (var q in query)
            {
                userMessages.Add(new UserMessageDTO
                {
                    SenderUsername = q.Sender.username,
                    message = q.message,
                    Date = q.Date,
                    sender_ip = q.sender_ip,
                    sender_device = q.sender_device
                });
            }
            
            return userMessages;
        }

    }
}