using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StadiumProject.Models1
{
    public partial class StadiumDbContext : DbContext
    {
        public StadiumDbContext()
        {
        }

        public StadiumDbContext(DbContextOptions<StadiumDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Reservation> Reservations { get; set; } = null!;
        public virtual DbSet<ReservationToRoom> ReservationToRooms { get; set; } = null!;
        public virtual DbSet<Room> Rooms { get; set; } = null!;
        public virtual DbSet<Stad> Stads { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-5A83I97; Initial Catalog=StadiumProjectDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {


                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(250);

                entity.Property(e => e.Surname).HasMaxLength(250);
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.Property(e => e.GameDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            });

            modelBuilder.Entity<ReservationToRoom>(entity =>
            {
                entity.HasIndex(e => e.ReservationId, "IX_ReservationToRooms_ReservationId");

                entity.HasIndex(e => e.RoomId, "IX_ReservationToRooms_RoomId");

                entity.HasOne(d => d.Reservation)
                    .WithMany(p => p.ReservationToRooms)
                    .HasForeignKey(d => d.ReservationId);

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.ReservationToRooms)
                    .HasForeignKey(d => d.RoomId);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.Capacity).HasMaxLength(100);


            });

            modelBuilder.Entity<Stad>(entity =>
            {


                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Number).HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
