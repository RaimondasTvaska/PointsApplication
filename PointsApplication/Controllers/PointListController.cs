using Microsoft.AspNetCore.Mvc;
using PointsApplication.Entities;
using PointsApplication.Services;
using System.Threading.Tasks;

namespace PointsApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PointListController : ControllerBase
    {
        private readonly PointListService _pointListService;

        public PointListController(PointListService pointListService)
        {
            _pointListService = pointListService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _pointListService.GetAllAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _pointListService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(PointList pointList)
        {
            await _pointListService.CreateAsync(pointList);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _pointListService.DeleteAsync(id);
            return NoContent();
        }
    }
}