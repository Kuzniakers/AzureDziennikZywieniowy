using Microsoft.AspNetCore.Mvc;
using dziennikzywieniowyAPI.Data;
using dziennikzywieniowyAPI.Models;
using System.Linq;

namespace dziennikzywieniowyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EntriesController(AppDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IActionResult GetEntries()
        {
            try
            {
                var entries = _context.Entries.ToList();
                return Ok(entries); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving entries.", error = ex.Message });
            }
        }

       
        [HttpPost]
        public IActionResult AddEntry([FromBody] Entry entry)
        {
            if (entry == null)
            {
                return BadRequest(new { message = "Entry cannot be null." });
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }

            try
            {
                _context.Entries.Add(entry);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetEntries), new { id = entry.Id }, entry); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while adding the entry.", error = ex.Message });
            }
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var entry = _context.Entries.FirstOrDefault(e => e.Id == id);
                if (entry == null)
                {
                    return NotFound(new { message = $"Entry with ID {id} not found." });
                }

                _context.Entries.Remove(entry);
                _context.SaveChanges();
                return NoContent(); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while deleting the entry.", error = ex.Message });
            }
        }
        [HttpPut("{id}")]
        public IActionResult UpdateEntry(int id, [FromBody] Entry updatedEntry)
        {
            if (id != updatedEntry.Id)
            {
                return BadRequest("ID in URL and body do not match.");
            }

            var entry = _context.Entries.FirstOrDefault(e => e.Id == id);
            if (entry == null)
            {
                return NotFound($"Entry with ID {id} not found.");
            }

            entry.MealName = updatedEntry.MealName;
            entry.Date = updatedEntry.Date;
            entry.Calories = updatedEntry.Calories;

            _context.Entries.Update(entry);
            _context.SaveChanges();

            return NoContent();
        }

    }
}