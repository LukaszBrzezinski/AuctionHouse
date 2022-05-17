using AuctionHouse.Core;
using System.Collections.Generic;
using System.Linq;

namespace AuctionHouse.Infrastructure
{
    internal class InMemoryUserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public bool UserExists(string email)
        {
            return _users.Any(u => u.Email.Equals(email, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
