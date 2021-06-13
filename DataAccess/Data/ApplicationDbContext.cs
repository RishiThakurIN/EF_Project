using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        //public DbSet<Category> Categories { get; set; }
        public DbSet<Gener> Geners { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<Publisher> publishers { get; set; }
        public DbSet<BookAuthor> bookAuthors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  Configure fluent API

            //  composite key (two or more column together uniquely identify an table row.
            modelBuilder.Entity<BookAuthor>()
                .HasKey(b => new { b.Author_Id, b.Book_Id });
        }

    }
}
