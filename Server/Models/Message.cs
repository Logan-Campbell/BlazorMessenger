using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LANMessanger.Server.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public int SenderId { get; set; }
        public virtual User Sender { get; set; }
        public int RecieverId { get; set; }
        public virtual User Reciever { get; set; }
        public string message { get; set; }
        public DateTimeOffset Date { get; set; }
        public string? sender_ip { get; set; }
        public string? sender_device { get; set; }

    }
}
