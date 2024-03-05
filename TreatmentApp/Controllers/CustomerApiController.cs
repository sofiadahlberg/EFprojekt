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
        public CustomerApiController(ApplicationDbContext context)
        {
            _context = context;
        }
        //Getanrop
        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            return Ok(await _context.Customers.ToListAsync());
        }

        [HttpGet("categories")]
        public IActionResult GetCategories()
        {
            var categories = _context.Treatments
                .Select(t => t.Category)
                .Distinct()
                .ToList();

            return Ok(categories);
        }
        //Postanrop
        [HttpPost]
        public async Task<IActionResult> CreateCustomers([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Det gick inte att lägga till");
            }
            try
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();

                // Returnerar den nya kunden som skapats (Med id)
                return CreatedAtAction(nameof(GetCustomers),
                 new { id = customer.CustomerId }, customer);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                //Vid felmeddelande
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
