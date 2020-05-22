using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MvcApp.Models {
    public class MySpotifyContext : DbContext {
        public DbSet<Musica> Musicas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder options) => options.UseSqlite ("Data Source=myspotify.db");

        protected override void OnModelCreating (ModelBuilder modelBuilder) {

            // modelBuilder.Entity<Musica> ()
            //     .ToTable ("Musicas");

            // modelBuilder.Entity<Musica> ()
            //     .Property (b => b.Genero)
            //     .IsRequired ();

            // modelBuilder.Entity<Musica> ()
            //     .Property (p => p.Regravacao)
            //     .HasMaxLength (20);

        }
    }

}