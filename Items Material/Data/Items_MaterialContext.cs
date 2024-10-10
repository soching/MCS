using System;
using System.Collections.Generic;
using Items_Material.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Items_Material.Data
{
    public partial class Items_MaterialContext : DbContext
    {
        public Items_MaterialContext()
        {
        }

        public Items_MaterialContext(DbContextOptions<Items_MaterialContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Itemsmaterial> Itemsmaterials { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-067JFQA\\MSSQLSERVER1;Database=ItemMaterial; user id = sa; pwd=123456789.;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Itemsmaterial>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__itemsmat__52020FDDA550477E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
