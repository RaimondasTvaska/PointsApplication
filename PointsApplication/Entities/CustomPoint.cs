namespace PointsApplication.Entities
{
    public class CustomPoint
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int? PointListId { get; set; } // nullable kadangi gali nepriklausyti kokiam nors listui
    }
}
