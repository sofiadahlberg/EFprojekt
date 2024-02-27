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

    }
}
