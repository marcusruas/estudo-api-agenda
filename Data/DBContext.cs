using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace agendaAPI.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contato> Contato { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>(entity =>
            {
                entity.HasKey(e => e.Idcontato);

                entity.ToTable("CONTATO");

                entity.Property(e => e.Idcontato).HasColumnName("IDCONTATO");

                entity.Property(e => e.Idade).HasColumnName("IDADE");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasColumnName("SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasColumnName("TELEFONE")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });
        }
    }
}
