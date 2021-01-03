using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProjetoFilmes.Domains;

namespace ProjetoFilmes.Contexts
{
    public partial class FilmesBDContext : DbContext
    {
        public FilmesBDContext()
        {
        }

        public FilmesBDContext(DbContextOptions<FilmesBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Filmes> Filmes { get; set; }
        public virtual DbSet<Generos> Generos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=LAB08DESK301\\SQLEXPRESS; Initial Catalog=Filmes; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filmes>(entity =>
            {
                entity.HasKey(e => e.IdFilme)
                    .HasName("PK__Filmes__6E8F2A76A84215E1");

                entity.HasIndex(e => e.Titulo)
                    .HasName("UQ__Filmes__7B406B56E26D4957")
                    .IsUnique();

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Filmes)
                    .HasForeignKey(d => d.IdGenero)
                    .HasConstraintName("FK__Filmes__IdGenero__3B75D760");
            });

            modelBuilder.Entity<Generos>(entity =>
            {
                entity.HasKey(e => e.IdGenero)
                    .HasName("PK__Generos__0F834988298C7DBC");

                entity.HasIndex(e => e.Nome)
                    .HasName("UQ__Generos__7D8FE3B2805ECD0C")
                    .IsUnique();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__5B65BF973E1A4670");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Usuarios__A9D10534E6C30023")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Permissao)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
