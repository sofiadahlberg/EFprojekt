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
    
    [HttpDelete("{id}")]
public async Task<IActionResult> DeleteTimeInterval(int id)
{
    try
    {
        var timeInterval = await _context.TimeIntervals.FindAsync(id);

        if (timeInterval == null)
        {
            return NotFound(); // Return 404 Not Found if the record doesn't exist
        }

        _context.TimeIntervals.Remove(timeInterval);
        await _context.SaveChangesAsync();

        return NoContent(); // Return 204 No Content on successful deletion
    }
    catch (Exception ex)
    {
        // Log or handle the exception as needed
        return StatusCode(500, $"Internal Server Error: {ex.Message}");
    }
}
    }

}
