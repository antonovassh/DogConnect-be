namespace DogConnect_be.Models.Post
{
    public class PostModel
    {
        public int PostId { get; set; }

        public int DogId { get; set; }

        public string Content { get; set; }

        public string Img { get; set; } 

        public DateTime TimeStamp { get; set; }
    }
}
