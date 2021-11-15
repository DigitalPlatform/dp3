using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEFCore
{
    public class SimpleDataStorage : DbContext
    {
        public SimpleDataStorage() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Set the filename of the database to be created
            optionsBuilder.UseSqlite("Data Source=db.sqlite");
        }

        public DbSet<Cat> Cats { get; set; }


        public DbSet<Dog> Dogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Define the Table(s) and References to be created automatically
            modelBuilder.Entity<Cat>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedOnAdd();
                b.Property(e => e.Name).IsRequired().HasMaxLength(255);
                b.ToTable("Cats");
            });

            //Define the Table(s) and References to be created automatically
            modelBuilder.Entity<Dog>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedOnAdd();
                b.ToTable("Dogs");
            });
        }
    }

    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class Dog
    {
        public int Id { get; set; }
        public string  Age{ get; set; }
    }
}
