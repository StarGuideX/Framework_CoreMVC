using System;

namespace Framework.Models
{
    public class User
    {
        private Guid id;
        private string username;
        private string password;

        public Guid Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
