﻿using Microsoft.EntityFrameworkCore;
using Notes.Domain.Entity;

namespace Notes.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<NoteEntity> Notes { get; set; }

    }
}
