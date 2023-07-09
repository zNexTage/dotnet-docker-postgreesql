using System;
using Microsoft.EntityFrameworkCore;
using DockerDotnetPostgre.Models;

namespace DockerDotnetPostgre.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Driver> Drivers {get;set;}
}
