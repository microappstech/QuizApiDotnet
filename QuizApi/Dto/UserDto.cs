﻿namespace QuizApi.Dto
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool isAdmin { get; set; }
    }
}
