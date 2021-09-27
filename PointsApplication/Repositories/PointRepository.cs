using Microsoft.EntityFrameworkCore;
using PointsApplication.Data;
using PointsApplication.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PointsApplication.Repositories
{
    public class PointRepository
    {
        private readonly DataContext _context;
        public PointRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<CustomPoint>> GetAsync()
        {
            return await _context.Points.ToListAsync();
        }
        public async Task<CustomPoint> GetByIdAsync(int id)
        {
            return await _context.Points.FirstOrDefaultAsync(p => p.Id == id);

        }

        public async Task AddAsync(CustomPoint point)
        {
            _context.Add(point);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(CustomPoint point)
        {
            _context.Remove(point);
            await _context.SaveChangesAsync();
        }
    }
}
