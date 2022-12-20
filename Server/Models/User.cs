using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LANMessanger.Server.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        
        public virtual IEnumerable<Message>? SentMessages { get; set; }
        
        public virtual IEnumerable<Message>? RecievedMessages { get; set; }
    }
}
