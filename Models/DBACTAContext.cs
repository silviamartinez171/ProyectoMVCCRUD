using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyectoMVCCRUD.Models
{
    public partial class DBACTAContext : DbContext
    {
        public DBACTAContext()
        {
        }

        public DBACTAContext(DbContextOptions<DBACTAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Notasest> Notasests { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
               // optionsBuilder.UseSqlServer("server=DESKTOP-B6G5UO3; Database=DBACTA; integrated security =true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notasest>(entity =>
            {
                entity.HasKey(e => e.Id)
                .HasName("PK__NOTASEST__3214EC07D9AF0F0B");

                entity.ToTable("NOTASEST");

                entity.Property(e => e.Apellido).HasMaxLength(30);

                entity.Property(e => e.Carnet).HasMaxLength(12);

                entity.Property(e => e.Iipn).HasColumnName("IIPN");

                entity.Property(e => e.Ipn).HasColumnName("IPN");

                entity.Property(e => e.Nf).HasColumnName("NF");

                entity.Property(e => e.Nombre).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
