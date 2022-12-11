using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LANMessanger.Server.Models;
using System.Data;

namespace LANMessenger.Server.Data
{
    public class LANMessengerServerContext : DbContext
    {
        public LANMessengerServerContext (DbContextOptions<LANMessengerServerContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Reciever)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Seed();
        }

        public DbSet<LANMessanger.Server.Models.User> User { get; set; } = default!;

        public DbSet<LANMessanger.Server.Models.Message> Message { get; set; } = default!;
    }
}
