using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WhatsApp.Models;

namespace WhatsApp.DataBase
{
    public class MyDB : DbContext
    {
        public MyDB(DbContextOptions<MyDB> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conversation>()
                .HasKey(c => c.ConversationID);

            modelBuilder.Entity<Conversation>()
                .HasOne(c => c.Participant1)
                .WithMany(u => u.Conversations)
                .HasForeignKey(c => c.Participant1ID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Conversation>()
                .HasOne(c => c.Participant2)
                .WithMany(u => u.Conversations)
                .HasForeignKey(c => c.Participant2ID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Message>()
                .HasKey(m => m.MessageID);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver);

            base.OnModelCreating(modelBuilder);
        }
    }
}
