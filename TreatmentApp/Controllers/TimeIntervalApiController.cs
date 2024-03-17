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
            return NotFound(); // Return 404 gick inte att hitta
        }

        _context.TimeIntervals.Remove(timeInterval);
        await _context.SaveChangesAsync();

        return NoContent(); // Returnera 204
    }
    catch (Exception ex)
    {
        // Logga fel eller hantera
        return StatusCode(500, $"Internal Server Error: {ex.Message}");
    }
}
    }

}
