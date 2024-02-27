using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TreatmentApp.Data;

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
    }
}
