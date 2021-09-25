using PointsApplication.Data;
using PointsApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<CustomPoint> Get()
        {
            throw new NotImplementedException();
        }
        public List<CustomPoint> GetById()
        {
            throw new NotImplementedException();
        }

    }
}
