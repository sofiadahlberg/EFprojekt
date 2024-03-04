using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TreatmentApp.Data;
using TreatmentApp.Models;

namespace MyApp.Namespace
{
    [Route("api/timeinterval")]
    [ApiController]
    public class TimeIntervalApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public TimeIntervalApiController(ApplicationDbContext context){
            _context = context;
        }
//Get
[HttpGet]
public async Task<IActionResult> GetTimeIntervals(){
return Ok(await _context.TimeIntervals.ToListAsync());
}
    }
}
