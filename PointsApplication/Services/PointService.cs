using PointsApplication.Entities;
using PointsApplication.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PointsApplication.Services
{
    public class PointService
    {
        private PointRepository _pointRepository;
        public PointService(PointRepository pointRepository)
        {
            _pointRepository = pointRepository;
        }
        public async Task<List<CustomPoint>> GetAllAsync()
        {
            return await _pointRepository.GetAsync();
        }
        public async Task<CustomPoint> GetByIdAsync(int id)
        {
            return await _pointRepository.GetByIdAsync(id);
        }
        public async Task AddAsync(CustomPoint point)
        {
            await _pointRepository.AddAsync(point);
        }

        public async Task DeleteAsync(int id)
        {
            var point = await GetByIdAsync(id);
            await _pointRepository.DeleteAsync(point);
        }
    }
}
