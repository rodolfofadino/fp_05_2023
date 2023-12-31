﻿using Microsoft.EntityFrameworkCore;

namespace fiap.core.Models
{
    public class MusicaContext : DbContext
    {
        public MusicaContext(DbContextOptions<MusicaContext> options) : base(options)
        {
        }

        public DbSet<Musica> Musicas { get; set; }
    }
}
