using Microsoft.EntityFrameworkCore;
using PointsApplication.Data;
using PointsApplication.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PointsApplication.Repositories
{
    public class PointListRepository
    {
        private readonly DataContext _dataContext;

        public PointListRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<PointList>> GetAllAsync()
        {
            return await _dataContext.PointLists.ToListAsync();
        }
        public async Task<PointList> GetByIdAsync(int id)
        {
            return await _dataContext.PointLists.FirstOrDefaultAsync(pl => pl.Id == id);
        }
        public async Task CreateAsync(PointList pointList)
        {
            _dataContext.Add(pointList);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(PointList pointList)
        {
            _dataContext.Remove(pointList);
            await _dataContext.SaveChangesAsync();
        }
    }
}
