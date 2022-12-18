using Microsoft.EntityFrameworkCore;
using LANMessanger.Server.Models;
using System.Diagnostics;

namespace LANMessenger.Server.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Users
            modelBuilder.Entity<User>().HasData
            (
                //GROUP USER, everyone can messagee this user, acts as a group chat
                new User
                {
                    Id = 1,
                    username = "Group",
                    password = "password"
                },
                //Example User
                new User
                {
                    Id = 100,
                    username = "John Doe",
                    password = "letmein"
                },
                //Example User
                new User
                {
                    Id = 101,
                    username = "Jane Smith",
                    password = "letmein"
                }
            );

            #endregion Users
            
            #region Messages
            //Add a real date and time to keep everything in order and model realistic behaviour.
            DateTime dateTime = DateTime.Now;
            List<Message> messages = new List<Message>
            {
                //Messages to the Group
                new Message
                {
                    Id = 1,
                    SenderId = 100,
                    RecieverId = 1,
                    message = "First.",
                    Date = new DateTimeOffset(dateTime),
                    sender_ip = "127.0.0.1",
                    sender_device = "Windows"
                },
                new Message
                {
                    Id = 2,
                    SenderId = 101,
                    RecieverId = 1,
                    message = "Second.",
                    Date = new DateTimeOffset(dateTime.AddMinutes(2)),
                    sender_ip = "127.0.0.1",
                    sender_device = "Mac"
                }
            };
            //Random Messages between users 100 and 101
            for (int i = 0; i < 100; i++)
            {
                Random rand = new Random();
                //Pick either user 100 or 101
                int user = 100 + rand.Next(2);
                //Add some time each loop
                dateTime = dateTime.AddMinutes(rand.Next(1, 10));
                messages.Add(new Message
                {
                    Id = i + 3,
                    SenderId = user == 100 ? 100 : 101,
                    RecieverId = user == 100 ? 101 : 100,
                    message = rand.NextInt64().ToString(),
                    Date = new DateTimeOffset(dateTime),
                    sender_ip = "127.0.0.1",
                    sender_device = user == 100 ? "Windows" : "Mac"
                });
            }

            modelBuilder.Entity<Message>().HasData(messages);
            
            #endregion
            

        }
    }
}
