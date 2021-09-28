using PointsApplication.Dtos;
using PointsApplication.Entities;
using PointsApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PointsApplication.Services
{
    public class PointListService
    {
        private readonly PointListRepository _pointListRepository;

        public PointListService(PointListRepository pointListRepository)
        {
            _pointListRepository = pointListRepository;
        }

        public async Task<List<PointList>> GetAllAsync()
        {
            return await _pointListRepository.GetAllAsync();
        }
        public async Task<PointList> GetByIdAsync(int id)
        {
            var pointList = await _pointListRepository.GetByIdAsync(id);
            if (pointList == null)
            {
                throw new ArgumentException("PointList not found");
            }
            return pointList;
        }
        public async Task DeleteAsync(int id)
        {
            var point = await GetByIdAsync(id);
            await _pointListRepository.DeleteAsync(point);
        }

        public async Task CreateAsync(PointListCreationDto pointListDto)
        {
            var entity = new PointList()
            {
                Name = pointListDto.Name
            };
            await _pointListRepository.CreateAsync(entity);
        }
    }
}
