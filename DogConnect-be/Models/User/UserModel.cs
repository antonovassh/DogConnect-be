﻿namespace DogConnect_be.Models.User
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime RegisterDate { get; set; }
    }
}
