using Microsoft.AspNetCore.Mvc;
using dziennikzywieniowyAPI.Data;
using dziennikzywieniowyAPI.Models;
using System.Linq;

namespace dziennikzywieniowyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaloricDeficitController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CaloricDeficitController(AppDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IActionResult GetDeficits()
        {
            var deficits = _context.CaloricDeficits.ToList();
            return Ok(deficits); 
        }

        
        [HttpPost]
        public IActionResult AddDeficit([FromBody] CaloricDeficit deficit)
        {
            if (deficit == null)
            {
                return BadRequest("Invalid data.");
            }

            _context.CaloricDeficits.Add(deficit);
            _context.SaveChanges();
            return Ok(deficit); 
        }

        
        [HttpPut("{id}")]
        public IActionResult UpdateDeficit(int id, [FromBody] CaloricDeficit updatedDeficit)
        {
            if (updatedDeficit == null || updatedDeficit.Id != id)
            {
                return BadRequest("Invalid data.");
            }

            var existingDeficit = _context.CaloricDeficits.FirstOrDefault(d => d.Id == id);
            if (existingDeficit == null)
            {
                return NotFound($"Caloric Deficit with ID {id} not found.");
            }

            
            existingDeficit.ActivityName = updatedDeficit.ActivityName;
            existingDeficit.CaloriesBurned = updatedDeficit.CaloriesBurned;
            existingDeficit.Date = updatedDeficit.Date;

            _context.CaloricDeficits.Update(existingDeficit);
            _context.SaveChanges();
            return Ok(existingDeficit); 
        }

        
        [HttpDelete("{id}")]
        public IActionResult DeleteDeficit(int id)
        {
            var deficit = _context.CaloricDeficits.FirstOrDefault(d => d.Id == id);
            if (deficit == null)
            {
                return NotFound();
            }

            _context.CaloricDeficits.Remove(deficit);
            _context.SaveChanges();
            return NoContent(); 
        }
    }
}
