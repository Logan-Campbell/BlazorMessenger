using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LANMessanger.Server.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        
        public int SenderId { get; set; }
        [ForeignKey("SenderId")]
        public User Sender { get; set; }
        public int RecieverId { get; set; }
        [ForeignKey("RecieverId")]
        public User Reciever { get; set; }
        public string message { get; set; }
        public DateTimeOffset Date { get; set; }
        public string? sender_ip { get; set; }
        public string? sender_device { get; set; }

    }
}
