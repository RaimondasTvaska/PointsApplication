using Microsoft.AspNetCore.Mvc;
using PointsApplication.Entities;
using PointsApplication.Services;
using System.Threading.Tasks;

namespace PointsApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PointController : ControllerBase
    {
        private readonly PointService _pointService;

        public PointController(PointService pointService)
        {
            _pointService = pointService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _pointService.GetAllAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var point = await _pointService.GetByIdAsync(id);
            if (point == null)
            {
                return NotFound();
            }
            return Ok(point);
        }
        [HttpPost]
        public async Task<IActionResult> Add(CustomPoint point)
        {
            await _pointService.AddAsync(point);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _pointService.DeleteAsync(id);
            return NoContent();
        }

    }
}
