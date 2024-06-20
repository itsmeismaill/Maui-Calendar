// AuthService.cs
using System;
using System.Collections.Generic;

namespace Calendrier
{
    public class AuthService
    {
        private Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "user1", "password1" } // Replace with your actual user credentials
        };

        public bool Authenticate(string username, string password)
        {
            if (users.ContainsKey(username) && users[username] == password)
            {
                return true;
            }
            return false;
        }
    }
}
