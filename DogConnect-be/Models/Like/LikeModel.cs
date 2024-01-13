namespace DogConnect_be.Models.Like
{
    public class LikeModel
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public int UserId { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
