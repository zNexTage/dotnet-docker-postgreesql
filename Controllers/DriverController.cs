using System;
using DockerDotnetMySql.Data;
using DockerDotnetMySql.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DockerDotnetMySql.Controllers;

[ApiController]
[Route("[Controller]")]
public class DriverController : ControllerBase
{
    private readonly ILogger<DriverController> _logger;
    private readonly AppDbContext _context;

    public DriverController(ILogger<DriverController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get(){
        //TODO: O conteúdo abaixo deveria estar em um Service; 
        var driver = new Driver (){
            Name = "Sir Lewis Hamilton",
            DriverNumber = 44
        };

        _context.Add(driver);

        await _context.SaveChangesAsync();

        var allDrivers = _context.Drivers.ToListAsync();

        return Ok(allDrivers);
    }



}
