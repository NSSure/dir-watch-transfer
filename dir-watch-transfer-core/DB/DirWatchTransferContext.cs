﻿using DirWatchTransfer.Core.DB.Config;
using DirWatchTransfer.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DirWatchTransfer.Core.DB
{
    public class DirWatchTransferContext : DbContext
    {
        public DbSet<SymbolicLink> SymbolicLink { get; set; }
        public DbSet<Watcher> Watcher { get; set; }
        public DbSet<ScheduledSync> ScheduledSync { get; set; }
        public DbSet<ActivityHistory> ActivityHistory { get; set; }
        public DbSet<Settings> Settings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={Path.Combine(Constants.ApplicationPath, "DirWatchTransferContext")}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SymbolicLinkConfig());
            modelBuilder.ApplyConfiguration(new ActivityHistoryConfig());
            modelBuilder.ApplyConfiguration(new ScheduledSyncConfig());
            modelBuilder.ApplyConfiguration(new WatcherConfig());
            modelBuilder.ApplyConfiguration(new SettingsConfig());
        }

        public static void Initialize()
        {
            using (DirWatchTransferContext context = new DirWatchTransferContext())
            {
                List<string> pendingMigrations = context.Database.GetPendingMigrations().ToList();

                if (pendingMigrations.Count != 0)
                {
                    context.Database.Migrate();
                }

                Settings defaultSettings = context.Settings.FirstOrDefault();

                if (defaultSettings == null)
                {
                    // Initialize default settings look at the property comment summaries for more details.
                    defaultSettings = new Settings();

                    context.Settings.Add(defaultSettings);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Drops and recreates the database. (Warning this DELETES any and all data in the existing database).
        /// </summary>
        /// <returns></returns>
        public static async Task ReinitializeDatabase()
        {
            using (DirWatchTransferContext context = new DirWatchTransferContext())
            {
                // Delete the database.
                await context.Database.EnsureDeletedAsync();

                // Reinitialize the database from scratch.
                Initialize();
            }
        }
    }
}
