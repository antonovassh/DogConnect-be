namespace DogConnect_be.Models.Dog
{
    public class DogModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public string ProfilePicture { get; set; }
    }
}
