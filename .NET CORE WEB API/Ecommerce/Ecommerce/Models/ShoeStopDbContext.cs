using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Models;

public partial class ShoeStopDbContext : DbContext
{
    public ShoeStopDbContext()
    {
    }

    public ShoeStopDbContext(DbContextOptions<ShoeStopDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }

    public virtual DbSet<ProductMasterTable> ProductMasterTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PTL014015\\SQLEXPRESS;Initial Catalog = ShoeStopDb;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("Order_Detail");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("Order_Id");
            entity.Property(e => e.ProductId).HasColumnName("Product_Id");
            entity.Property(e => e.TotalAmount).HasColumnName("Total_Amount");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Detail_Product_Master_Table");
        });

        modelBuilder.Entity<PaymentDetail>(entity =>
        {
            entity.HasKey(e => e.PaymentId);

            entity.ToTable("Payment_details");

            entity.Property(e => e.PaymentId)
                .ValueGeneratedNever()
                .HasColumnName("Payment_Id");
            entity.Property(e => e.PaymentType)
                .HasColumnType("text")
                .HasColumnName("Payment_Type");
            entity.Property(e => e.ProductId).HasColumnName("Product_Id");
            entity.Property(e => e.TotalAmount).HasColumnName("Total_Amount");

            entity.HasOne(d => d.Product).WithMany(p => p.PaymentDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_details_Product_Master_Table");
        });

        modelBuilder.Entity<ProductMasterTable>(entity =>
        {
            entity.HasKey(e => e.ProductId);

            entity.ToTable("Product_Master_Table");

            entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("Product_ID");
            entity.Property(e => e.ProductBrand)
                .HasColumnType("text")
                .HasColumnName("Product_Brand");
            entity.Property(e => e.ProductCategory)
                .HasColumnType("text")
                .HasColumnName("Product_Category");
            entity.Property(e => e.ProductDesacription)
                .HasColumnType("text")
                .HasColumnName("Product_Desacription");
            entity.Property(e => e.ProductGender)
                .HasColumnType("text")
                .HasColumnName("Product_Gender");
            entity.Property(e => e.ProductName)
                .HasColumnType("text")
                .HasColumnName("Product_Name");
            entity.Property(e => e.ProductPrice).HasColumnName("Product_Price");
            entity.Property(e => e.ProductStock).HasColumnName("Product_Stock");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
