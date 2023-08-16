using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.A_DAL.Models;

public partial class AssetContext : DbContext
{
    public AssetContext()
    {
    }

    public AssetContext(DbContextOptions<AssetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LoaiTaiSan> LoaiTaiSans { get; set; }

    public virtual DbSet<TaiSan> TaiSans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-KTU5UAP\\SQLEXPRESS;Initial Catalog=Asset;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LoaiTaiSan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoaiTaiSan");

            entity.Property(e => e.MaLoaiTs)
                .ValueGeneratedOnAdd()
                .HasColumnName("MaLoaiTS");
            entity.Property(e => e.TenLoaiTs)
                .HasMaxLength(50)
                .HasColumnName("TenLoaiTS");
        });

        modelBuilder.Entity<TaiSan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TaiSan");

            entity.Property(e => e.MaLoaiTs).HasColumnName("MaLoaiTS");
            entity.Property(e => e.MaTaiSan).ValueGeneratedOnAdd();
            entity.Property(e => e.NgayMua).HasColumnType("date");
            entity.Property(e => e.TenTaiSan).HasMaxLength(50);
            entity.Property(e => e.TinhTrang).HasMaxLength(20);
            entity.Property(e => e.TrangThaiSd)
                .HasMaxLength(20)
                .HasColumnName("TrangThaiSD");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
