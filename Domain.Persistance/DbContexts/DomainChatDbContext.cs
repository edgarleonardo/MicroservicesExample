using Domain.Persistance.ModelConfigs;
using MicroservicesExample.Domain.BaseEntity;
using MicroservicesExample.Domain.ChatChannel;
using MicroservicesExample.Domain.Messages;
using MicroservicesExample.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace Domain.Persistance.DbContexts
{
    public class DomainChatDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Channel> Channel { get; set; }
        public DbSet<ChannelUsers> ChannelUsers { get; set; }
        public DbSet<Message> Message { get; set; }

        public static readonly LoggerFactory ConsoleLoggerFactory
      = new LoggerFactory();

        public DomainChatDbContext(DbContextOptions<DomainChatDbContext> options)
               : base(options)
        {
        }

        public DomainChatDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder
            //        .UseLoggerFactory(ConsoleLoggerFactory)
            //        .UseSqlServer(
            //         "Server = (localdb)\\mssqllocaldb; Database = SchoolAdmin2; Trusted_Connection = True; ")
            //         .EnableSensitiveDataLogging(true);
            //}
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChannelUsersConfig());
            modelBuilder.Entity<User>().HasData(
                                 new User
                                 {
                                     Id = Guid.NewGuid().ToString() ,
                                     UserName = "started",
                                     UserPassword = "started",
                                     LastName = "started",
                                     Name = "started"
                                 }
                     );
        }

        public void Save()
        {
            SaveChanges();
        }
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            var timestamp = DateTime.Now;
            foreach (var entry in ChangeTracker.Entries()
                .Where(e =>
                    (e.State == EntityState.Added || e.State == EntityState.Modified) &&
                    e.GetType().BaseType == typeof(Entity) &&
                    !e.Metadata.IsOwned()))
            {
                entry.Property("UpdatedDate").CurrentValue = timestamp;
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedDate").CurrentValue = timestamp;
                }
            }
            return base.SaveChanges();
        }
    }
}
