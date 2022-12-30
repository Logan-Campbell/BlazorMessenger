using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMessenger.Shared.Models
{
    public class MessageDTO
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public virtual UserDTO? Sender { get; set; }
        public int RecieverId { get; set; }
        public virtual UserDTO? Reciever { get; set; }
        public string message { get; set; }
        public DateTimeOffset Date { get; set; }
        public string? sender_ip { get; set; }
        public string? sender_device { get; set; }
    }
}
