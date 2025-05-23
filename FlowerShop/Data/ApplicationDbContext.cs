﻿using Microsoft.EntityFrameworkCore;
using FlowerShop.Models;

namespace FlowerShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Plant> Plants { get; set; }
    }
}
