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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        private List<UserMessageDTO> BuildUserMessages(IEnumerable<Message> users)
        {
            List<UserMessageDTO> userMessages = new List<UserMessageDTO>();
            foreach (var user in users)
            {
                userMessages.Add(new UserMessageDTO
                {
                    SenderUsername = user.Sender.username,
                    message = user.message,
                    Date = user.Date,
                    sender_ip = user.sender_ip,
                    sender_device = user.sender_device
                });
            }
            return userMessages;
        }

        // GET: api/UserMessages/5
        /// <summary>
        /// Get all messages sent to a user, used for group chat
        /// </summary>
        /// <param name="recieverId"></param>
        /// <returns></returns>
        [HttpGet("Group")]
        public async Task<ActionResult<IEnumerable<UserMessageDTO>>> GetUserMessagesByRecieverId([FromQuery] int recieverId)
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

            //Convert Message + User to a userMessages List, and return
            return BuildUserMessages(query);
        }

        // GET: api/UserMessages?reciverId=5&senderId=5
        /// <summary>
        /// Gets all messages between two users
        /// </summary>
        /// <param name="recieverId"></param>
        /// <param name="senderId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserMessageDTO>>> GetUserMessagesByRecieverAndSenderId([FromQuery] int recieverId, [FromQuery] int senderId)
        {
            if (_context.Message == null || _context.User == null)
            {
                return NotFound();
            }

            var query = await _context
                .Message
                .Include(u => u.Sender)
                .Where(m => (m.RecieverId == recieverId && m.SenderId == senderId) ||
                            (m.RecieverId == senderId && m.SenderId == recieverId)) //retrive the other side of the conversation
                .ToListAsync();

            //Convert Message + User to a userMessages List, and return
            return BuildUserMessages(query);
        }

    }
}