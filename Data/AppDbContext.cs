using System;
using Microsoft.EntityFrameworkCore;
using DockerDotnetMySql.Models;

namespace DockerDotnetMySql.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Driver> Drivers {get;set;}
}
