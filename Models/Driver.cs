using System;

namespace DockerDotnetPostgre.Models;
public class Driver
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public int DriverNumber { get; set; }
}
