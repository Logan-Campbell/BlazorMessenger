using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMessenger.Shared.Models
{
    public class UserMessageDTO
    {
        public string SenderUsername { get; set; }
        public string message { get; set; }
        public DateTimeOffset Date { get; set; }
        public string? sender_ip { get; set; }
        public string? sender_device { get; set; }
    }
}
