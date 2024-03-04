using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TreatmentApp.Data;
using TreatmentApp.Models;

namespace MyApp.Namespace
{
    [Route("api/treatment")]
    [ApiController]
    public class TreatmentApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public TreatmentApiController(ApplicationDbContext context)
        {
            _context = context;
        }
        //Get
        [HttpGet]
        public async Task<IActionResult> GetTreatments()
        {
            return Ok(await _context.Treatments.ToListAsync());
        }

[HttpGet("available-timeintervals")]
public async Task<IActionResult> GetAvailableTimeIntervals([FromQuery] DateTime date)
{
    // Query the database or perform logic to get available time intervals for the specified date

    // Example: Retrieve all time intervals for the specified date
    var availableTimeIntervals = await _context.TimeIntervals
        .Where(ti => ti.StartTime.Date == date.Date && ti.Available)
        .ToListAsync();

    if (availableTimeIntervals.Any())
    {
        return Ok(availableTimeIntervals);
    }

    return NotFound("No available time intervals found for the specified date.");
}

        
    }
}
