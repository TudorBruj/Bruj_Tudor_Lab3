using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bruj_Tudor_Lab3.Models;

namespace Bruj_Tudor_Lab3.Data
{
    public class Bruj_Tudor_Lab3Context : DbContext
    {
        public Bruj_Tudor_Lab3Context (DbContextOptions<Bruj_Tudor_Lab3Context> options)
            : base(options)
        {
        }

        public DbSet<Bruj_Tudor_Lab3.Models.Book> Book { get; set; } = default!;

        public DbSet<Bruj_Tudor_Lab3.Models.Publisher>? Publisher { get; set; }

        public DbSet<Bruj_Tudor_Lab3.Models.Author>? Author { get; set; }

        public DbSet<Bruj_Tudor_Lab3.Models.Category>? Category { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(e => e.Borrowing)
            .WithOne(e => e.Book)
                .HasForeignKey<Borrowing>("BookID");
        }
        public DbSet<Bruj_Tudor_Lab3.Models.Member>? Member { get; set; }
        public DbSet<Bruj_Tudor_Lab3.Models.Borrowing>? Borrowing { get; set; }
    }
}
