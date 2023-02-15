using System;
using System.Collections.Generic;
using KARTRIGE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KARTRIGE.DataBase
{
    public partial class user05Context : DbContext
    {
        public user05Context()
        {
        }

        static user05Context instance;
        public static user05Context GetInstance()
        { 
            if(instance == null)
                instance = new user05Context();
            return instance;
        }

        public user05Context(DbContextOptions<user05Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabinet> Cabinets { get; set; } = null!;
        public virtual DbSet<Device> Devices { get; set; } = null!;
        public virtual DbSet<Material> Materials { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderType> OrderTypes { get; set; } = null!;
        public virtual DbSet<TypeMaterial> TypeMaterials { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)
            {
                

#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=192.168.200.35; database=user05;user=user05;password=44084");
                // localhost 127.0.0.1/sqlexpress
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cabinet>(entity =>
            {
                entity.ToTable("Cabinet");

                entity.Property(e => e.CabinetId).HasColumnName("CabinetID");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("Device");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.MaterialsId);

                entity.Property(e => e.MaterialsId).HasColumnName("MaterialsID");

                entity.HasOne(d => d.TypeMaterialsNavigation)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.TypeMaterialsId)
                    .HasConstraintName("FK_Materials_TypeMaterials");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CabinetId).HasColumnName("CabinetID");

                entity.Property(e => e.IdorderDevice).HasColumnName("IDOrderDevice");

                entity.Property(e => e.IdorderType).HasColumnName("IDOrderType");

                entity.HasOne(d => d.Cabinet)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CabinetId)
                    .HasConstraintName("FK_Orders_Cabinet");

                entity.HasOne(d => d.IdorderDeviceNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdorderDevice)
                    .HasConstraintName("FK_Orders_Device");

                entity.HasOne(d => d.IdorderTypeNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdorderType)
                    .HasConstraintName("FK_Orders_OrderType");

                entity.HasOne(d => d.Materials)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.MaterialsId)
                    .HasConstraintName("FK_Orders_Materials");
            });

            modelBuilder.Entity<OrderType>(entity =>
            {
                entity.ToTable("OrderType");

                entity.Property(e => e.OrderTypeId).HasColumnName("OrderTypeID");
            });

            modelBuilder.Entity<TypeMaterial>(entity =>
            {
                entity.HasKey(e => e.TypeMaterialsId);

                entity.Property(e => e.TypeMaterialsId).HasColumnName("TypeMaterialsID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
