using Microsoft.EntityFrameworkCore;
using LANMessanger.Server.Models;

namespace LANMessenger.Server.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Users
            modelBuilder.Entity<User>().HasData
            (
                //GROUP USER
                new User
                {
                    Id = 1,
                    username = "Group",
                    password = "password"
                },
                new User
                {
                    Id = 100,
                    username = "John Doe",
                    password = "letmein"
                },
                new User
                {
                    Id = 101,
                    username = "Jane Smith",
                    password = "letmein"
                }
            );

            #endregion Users

            #region Messages
            
            IEnumerable<Message> messages = new List<Message>();
            //Messages to the Group
            messages.Append(
                new Message
                {
                    Id = 1,
                    SenderId = 100,
                    RecieverId = 1,
                    message = "First.",
                    Date = new DateTimeOffset(),
                    sender_ip = "127.0.0.1",
                    sender_device = "Windows"
                });
            messages.Append(
                new Message
                {
                    Id = 2,
                    SenderId = 101,
                    RecieverId = 1,
                    message = "Second.",
                    Date = new DateTimeOffset(),
                    sender_ip = "127.0.0.1",
                    sender_device = "Mac"
                });
            //Random Messages between users 100 and 101
            for (int i = 0; i < 100; i++)
            {
                Random rand = new Random();
                int user = 100 + rand.Next(2);
                messages.Append(new Message
                {
                    Id = i + 3,
                    SenderId = 100,
                    RecieverId = user == 100 ? 101 : 100,
                    message = rand.NextInt64().ToString(),
                    Date = new DateTimeOffset(),
                    sender_ip = "127.0.0.1",
                    sender_device = user == 100 ? "Windows" : "Mac"
                });
            }

            modelBuilder.Entity<Message>().HasData(messages);
            #endregion
        }
    }
}
