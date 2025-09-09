using BookAuthorApi.Core.Entities;
﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
namespace BookAuthorApi.Infrastructure
{
    public class BookAuthorDbContext : DbContext
    {
        public BookAuthorDbContext(DbContextOptions<BookAuthorDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId);
            base.OnModelCreating(modelBuilder);
        }
    }
}


