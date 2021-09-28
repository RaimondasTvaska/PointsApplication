using System.Collections.Generic;

namespace PointsApplication.Entities
{
    public class PointList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CustomPoint> Points { get; set; }

    }
}
