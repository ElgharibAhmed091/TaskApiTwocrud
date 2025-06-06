﻿using Microsoft.EntityFrameworkCore;
using TaskApiTwo.Models;

namespace TaskApiTwo.Data
{
    public class ApplicationDbContext:DbContext
    {
            public DbSet<User> Users { get; set; }

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
 