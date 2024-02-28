using TreatmentApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using TreatmentApp.Data;

namespace MyApp.Namespace
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CustomerApiController(ApplicationDbContext context){
            _context = context;
        }
//Get
[HttpGet]
public async Task<IActionResult> GetCustomers(){
return Ok(await _context.Customers.ToListAsync());
}

//Postanrop
[HttpPost]
public async Task<IActionResult> CreateCustomers([FromBody] Customer customer){
    if (customer == null)
    {
        return BadRequest("Det gick inte att lägga till");
    }
    try{
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
    
    // Return the newly created customer with its ID
        return CreatedAtAction(nameof(GetCustomers), new { id = customer.CustomerId }, customer);
    }
    catch (Exception ex )
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
        // Log the exception or handle it as needed
        return StatusCode(500, "Internal server error");
    }
    }
}
}
