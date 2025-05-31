using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly InventoryService _service;

        public InventoryController(InventoryService service)
        {
            _service = service;
        }

        [HttpGet("GetGalaDetails")]
        public async Task<ActionResult<IEnumerable<GalaDetails>>> GetGalaDetails()
        {
            var items = await _service.GetGalaDetailsAsync();
            return Ok(items);
        }

        [HttpGet("GetQualityDetails")]
        public async Task<ActionResult<IEnumerable<QualityDetails>>> GetQualityDetails()
        {
            var items = await _service.GetQualityDetailsAsync();
            return Ok(items);
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<DBModels>> Get(int id)
        //{
        //    var item = await _service.GetByIdAsync(id);
        //    if (item == null) return NotFound();
        //    return Ok(item);
        //}

        //[HttpPost]
        //public async Task<ActionResult<DBModels>> Post([FromBody] DBModels inventory)
        //{
        //    var created = await _service.AddAsync(inventory);
        //    return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, [FromBody] DBModels inventory)
        //{
        //    var updated = await _service.UpdateAsync(id, inventory);
        //    if (!updated) return NotFound();
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var deleted = await _service.DeleteAsync(id);
        //    if (!deleted) return NotFound();
        //    return NoContent();
        //}
    }
}