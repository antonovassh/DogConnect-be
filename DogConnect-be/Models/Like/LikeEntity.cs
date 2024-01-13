namespace DogConnect_be.Models.Like
{
    public class LikeEntity
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public int UserId { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
