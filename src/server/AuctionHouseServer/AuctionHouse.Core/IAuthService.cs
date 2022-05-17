using System;

namespace AuctionHouse.Core
{
    public interface IAuthService
    {
        void Register(User user);
    }

    internal class AuthService : IAuthService
    {
        private readonly IUserRepository userRepository;

        public AuthService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public void Register(User user)
        {
            var userExists = userRepository.UserExists(user.Email);

            if (userExists)
            {
                throw new Exception($"User with email {user.Email} exists");
            }

            userRepository.AddUser(user);
        }
    }

}
