namespace BakersAPI.Models
{
    public class Bakeritem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public string? BakerName { get; set; }
        public string? ImageUrl { get; set; }

        public bool IsDone { get; set; }
    }
}
