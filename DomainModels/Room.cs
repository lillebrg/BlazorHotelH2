namespace DomainModels
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomType { get; set; }
        public int Price { get; set; }
        public bool VacancyToday { get; set; }
        public int MaxPeople { get; set; }
        public List<Picture> Pictures { get; set; }
    }
}
