using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.DataAccess.Concrete.EntityFrameworkCore.Context
{
   public class WriterManagementWebAPIContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=WriterManagement; user id=sa; password=123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ContentMap());
            modelBuilder.ApplyConfiguration(new HeadingMap());
            modelBuilder.ApplyConfiguration(new WriterMap());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
