using System;
using System.Collections.Generic;
using FragrantWorld.Mode1s;
using Microsoft.EntityFrameworkCore;

namespace FragrantWorld.DatabaseContext;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderProduct> OrderProducts { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<PickupPoint> PickupPoints { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=PerfumeParadise;Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientOrderId);

            entity.Property(e => e.ClientOrderId).ValueGeneratedNever();
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.Patronymic).HasMaxLength(255);

            entity.HasOne(d => d.ClientOrder).WithOne(p => p.Client)
                .HasForeignKey<Client>(d => d.ClientOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_To_Clients");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.ManufacturerId).HasName("PK__Manufact__357E5CA1683F214E");

            entity.ToTable("Manufacturer");

            entity.Property(e => e.ManufacturerName).HasMaxLength(100);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.OrderId).ValueGeneratedNever();
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");

            entity.HasOne(d => d.OrderStatusNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OrderStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_To_OrderStatuses");

            entity.HasOne(d => d.PickupPointNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.PickupPoint)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_To_PickupPoints");
        });

        modelBuilder.Entity<OrderProduct>(entity =>
        {
            entity.HasKey(e => new { e.OrderProductId, e.ProductArticleNumber }).HasName("PK__OrderPro__817A26023F6AF9A1");

            entity.ToTable("OrderProduct");

            entity.Property(e => e.ProductArticleNumber).HasMaxLength(100);

            entity.HasOne(d => d.OrderProductNavigation).WithMany(p => p.OrderProducts)
                .HasForeignKey(d => d.OrderProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderProduct_Orders");

            entity.HasOne(d => d.ProductArticleNumberNavigation).WithMany(p => p.OrderProducts)
                .HasForeignKey(d => d.ProductArticleNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderProd__Produ__5AB9788F");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.Property(e => e.OrderStatusId).ValueGeneratedNever();
            entity.Property(e => e.StatusName).HasMaxLength(15);
        });

        modelBuilder.Entity<PickupPoint>(entity =>
        {
            entity.Property(e => e.PickupPointId).ValueGeneratedNever();
            entity.Property(e => e.City).HasMaxLength(60);
            entity.Property(e => e.Street).HasMaxLength(60);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductArticleNumber).HasName("PK_Product_1");

            entity.ToTable("Product");

            entity.Property(e => e.ProductArticleNumber).HasMaxLength(100);
            entity.Property(e => e.ProductCost).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.ProductName).HasMaxLength(60);
            entity.Property(e => e.ProductStatus).HasMaxLength(15);
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__ProductC__19093A2B61F75003");

            entity.ToTable("ProductCategory");

            entity.Property(e => e.CategoryName).HasMaxLength(100);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK_Role");

            entity.Property(e => e.RoleId).ValueGeneratedNever();
            entity.Property(e => e.RoleName).HasMaxLength(15);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_User");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Login).HasMaxLength(32);
            entity.Property(e => e.Password).HasMaxLength(28);
            entity.Property(e => e.Patronymic).HasMaxLength(50);

            entity.HasOne(d => d.UserRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.UserRole)
                .HasConstraintName("FK_Roles_Users");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
