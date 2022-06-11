﻿using EFCoreExamples.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExamples.Database
{
    public class SMECommerceDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connetionstring =@"Server=DESKTOP-8109KK2\SQLEXPRESS;Database=SMECommerceDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder
                //.UseLazyLoadingProxies()
                .UseSqlServer(connetionstring);
                
               
        }
    }
}
