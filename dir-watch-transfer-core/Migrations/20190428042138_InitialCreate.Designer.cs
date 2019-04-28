﻿// <auto-generated />
using System;
using DirWatchTransfer.Core.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DirWatchTransfer.Core.Migrations
{
    [DbContext(typeof(DirWatchTransferContext))]
    [Migration("20190428042138_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("DirWatchTransfer.Core.Entity.ActivityHistory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("ActivityHistory");
                });

            modelBuilder.Entity("DirWatchTransfer.Core.Entity.ScheduledSync", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Enabled");

                    b.Property<int>("Interval");

                    b.Property<DateTime>("LastSync");

                    b.Property<int>("SymbolicLinkID");

                    b.HasKey("ID");

                    b.ToTable("ScheduledSync");
                });

            modelBuilder.Entity("DirWatchTransfer.Core.Entity.SymbolicLink", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Source");

                    b.Property<string>("Target");

                    b.HasKey("ID");

                    b.ToTable("SymbolicLink");
                });

            modelBuilder.Entity("DirWatchTransfer.Core.Entity.Watcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Recursive");

                    b.Property<int>("SymbolicLinkID");

                    b.Property<bool>("WatchCreationTime");

                    b.Property<bool>("WatchDirectoryName");

                    b.Property<bool>("WatchFileName");

                    b.Property<bool>("WatchLastAccess");

                    b.Property<bool>("WatchLastWrite");

                    b.Property<bool>("WatchSecurity");

                    b.Property<bool>("WatchSize");

                    b.HasKey("ID");

                    b.ToTable("Watcher");
                });
#pragma warning restore 612, 618
        }
    }
}
